using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Cookers;
using DAL.Fake.Model.GoodData.Coupons;
using DAL.Fake.Model.GoodData.DeliveryZones;
using DAL.Fake.Model.GoodData.OrderItems;
using DAL.Fake.Model.GoodData.Promotions;
using DAL.Fake.Model.KMLHelper;
using DAL.Fake.Model.LookUp.Discount;
using DAL.Fake.Model.LookUp.PaymentMethod;
using DAL.Fake.Model.Util.Common;
using DAL.Fake.Model.Util.Helper;
using DAL.Generic.UnitofWork;
using Model;
using OrderModelType = DAL.Fake.Model.LookUp.OrderModel.OrderModelType;
using OrderType = DAL.Fake.Model.LookUp.OrderType.OrderType;

namespace DAL.Fake.Model.Util.Orders
{
    public class OrderCharge
    {
        #region Fields

        #region Location
        private readonly List<DeliveryZone> _deliveryZones;
        private readonly List<CookerDeliveryZone> _cookerDeliveryZones;
        private readonly ClientAddress _deliveryAddress;

        private readonly List<Promotion> _promotions;
        private readonly List<Coupon> _coupons;
        #endregion

        #region Model
        private readonly List<OrderItem> _orderItem;
        private OrderChargeModel _orderCharge;
        #endregion

        #endregion

        public OrderCharge(ClientAddress deliveryAddress = null, UnitofWork uow = null)
        {
            if (uow == null)
            {
                _orderItem = new FakeOrderItems().MyOrderItems;
                _deliveryZones = new FakeDeliveryZone().MyDeliveryZones;
                _cookerDeliveryZones = new FakeCookerDeliveryZone().MyCookerDeliveryZones;
                _promotions = new FakePromotions().MyPromotions;
                _coupons = new FakeCoupons().MyCoupons;
            }
            else
            {
                _orderItem = uow.OrderItemRepository.All.ToList();
                _deliveryZones = uow.DeliveryZoneRepository.All.ToList();
                _cookerDeliveryZones = uow.CookerDeliveryZoneRepository.All.ToList();
                _promotions = uow.PromotionRepository.All.ToList();
                _coupons = uow.CouponRepository.All.ToList();
            }


            if (deliveryAddress != null)
            {
                _deliveryAddress = deliveryAddress;
            }
        }

        public OrderChargeModel Calculate(Order order)
        {
            var orderItems = (from c in _orderItem where c.OrderId == order.OrderId select c).ToList();
            if (orderItems.Any())
            {
                _orderCharge = new OrderChargeModel();
                var firstOrderItem = orderItems.FirstOrDefault();
                if (firstOrderItem != null) _orderCharge.CookerId = firstOrderItem.CookerId;
                var taxPercent = new Common.Util().GetTaxPercent(_orderCharge.CookerId);
                _orderCharge.OrderTypeValue = Enum.GetName(typeof(OrderModelType.Values), order.OrderTypeId);
                _orderCharge.PaymentMethodValue = Enum.GetName(typeof(PaymentMethodType.Values), order.PaymentMethodId);

                #region PickUpOrderCharge

                if (order.OrderTypeId == (int)OrderType.Values.PickUp)
                {
                    _orderCharge = PickUpCharge(order, taxPercent);
                }

                #endregion

                #region DeliveryOrderCharge

                var cookerDelieryZonesId = (from c in _cookerDeliveryZones where c.CookerId == _orderCharge.CookerId select c.DeliveryId).ToList();

                decimal deliveryFees = 0;
                foreach (var deliveryZoneId in cookerDelieryZonesId)
                {
                    //Custom KML Function to see if the item is in the zone
                    //Moq for now
                    var deliveryzone = _deliveryZones.FirstOrDefault(c => c.DeliveryId == deliveryZoneId);

                    //KML integration to see if deliveryaddress is Zone
                    if (_deliveryAddress.AddressTypeId == (int)AddressToDeliveryZone.Values.AddressInZone)
                    {
                        if (deliveryzone != null)
                        {
                            deliveryFees = deliveryzone.DeliveryFees;
                        }
                    }
                }

                _orderCharge = DeliveryCharge(order, deliveryFees, taxPercent);

                #endregion

                _orderCharge.SalesTaxes = new Money().RoundTo2Decimal(CalculateSalesTax(_orderCharge.TotalCharges, taxPercent));
                _orderCharge.PlanTitle = null;
                return _orderCharge;
            }
            return null;
        }

        #region Order Charges

        private OrderChargeModel PickUpCharge(Order order, decimal? taxPercent)
        {
            if (taxPercent == null)
            {
                taxPercent = 1;
            }
            return new OrderChargeModel
            {
                DeliveryFee = 0,
                SalesTaxes = new Money().RoundTo2Decimal((decimal)(order.SubTotal * taxPercent) / 100),
                Subtotal = order.SubTotal,
                TotalCharges = new Money().RoundTo2Decimal(CalculateCharges(order, (decimal)(order.SubTotal * taxPercent) / 100 + order.SubTotal))
            };
        }

        private OrderChargeModel DeliveryCharge(Order order, decimal deliveryFee, decimal? taxPercent)
        {
            if (taxPercent == null)
            {
                taxPercent = 1;
            }
            return new OrderChargeModel
            {
                DeliveryFee = deliveryFee,
                SalesTaxes = new Money().RoundTo2Decimal((decimal)((order.SubTotal + deliveryFee) * taxPercent) / 100),
                Subtotal = order.SubTotal,
                TotalCharges = new Money().RoundTo2Decimal(CalculateCharges(order, (decimal)(deliveryFee + (order.SubTotal + deliveryFee) * taxPercent) / 100 + order.SubTotal))
            };
        }

        #endregion

        #region Calculate Charges

        private decimal CalculateCharges(Order order, decimal charges)
        {
            return CalulateChargeAfterCoupon(CalulateChargeAfterPromotion(charges, order.PromotionId), order.CouponId);

        }

        #endregion

        #region Calculate Sales Tax

        private decimal CalculateSalesTax(decimal charges, decimal? taxes)
        {
            if (taxes == 1)
            {
                return 0;
            }
            var salesTaxCharges = charges * taxes;
            return salesTaxCharges ?? 0;
        }

        #endregion

        #region Promotion

        private decimal CalulateChargeAfterPromotion(decimal charge, int? promotionId)
        {
            if (promotionId == null)
            {
                return charge;
            }
            var promotion = _promotions.FirstOrDefault(x => x.PromotionId == promotionId);
            if (promotion == null) return charge;
            var currentPromotionId = promotion.PromotionId;

            if (currentPromotionId == 0)
            {
                return charge;
            }
            switch (currentPromotionId)
            {
                case (int)DisountType.Values.PercentageOff:
                    {
                        return charge - promotion.Price * charge;
                    }
                case (int)DisountType.Values.AmountOff:
                    {
                        return charge - promotion.Price;
                    }
                case (int)DisountType.Values.FixedAmount:
                    {
                        return promotion.Price;
                    }
            }
            return charge;
        }

        #endregion

        #region Coupon

        private decimal CalulateChargeAfterCoupon(decimal charge, int? couponId)
        {
            if (couponId == null)
            {
                return charge;
            }
            var coupon = _coupons.FirstOrDefault(x => x.CouponId == couponId);
            if (coupon == null) return charge;
            var currentCouponId = coupon.CouponId;

            if (currentCouponId == 0)
            {
                return charge;
            }
            switch (currentCouponId)
            {
                case (int)DisountType.Values.PercentageOff:
                    {
                        return charge - coupon.Price * charge;
                    }
                case (int)DisountType.Values.AmountOff:
                    {
                        return charge - coupon.Price;
                    }
                case (int)DisountType.Values.FixedAmount:
                    {
                        return coupon.Price;
                    }
            }
            return charge;
        }

        #endregion

    }
}
