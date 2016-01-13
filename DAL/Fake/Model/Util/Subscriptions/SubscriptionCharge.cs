using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Coupons;
using DAL.Fake.Model.GoodData.Promotions;
using DAL.Fake.Model.LookUp.Discount;
using DAL.Fake.Model.LookUp.PaymentMethod;
using DAL.Fake.Model.Util.Common;
using DAL.Fake.Model.Util.Helper;
using DAL.Generic.UnitofWork;
using Model;
using OrderModelType = DAL.Fake.Model.LookUp.OrderModel.OrderModelType;

namespace DAL.Fake.Model.Util.Subscriptions
{
    public class SubscriptionCharge
    {
        #region Fields

        #region Location
        private readonly List<DeliveryZone> _deliveryZones;
        private readonly List<CookerDeliveryZone> _cookerDeliveryZones;
        private readonly ClientAddress _deliveryAddress;
        #endregion

        #region ModelandHelper
        private OrderChargeModel _orderCharge;
        private readonly SubscriptionHelper _subscriptionHelper;
        #endregion


        #endregion

        public SubscriptionCharge(ClientAddress deliveryAddress = null, UnitofWork uow = null)
        {
            _subscriptionHelper = uow == null ? new SubscriptionHelper() : new SubscriptionHelper(uow);

            _orderCharge= new OrderChargeModel();
            if (deliveryAddress != null)
            {
                _deliveryAddress = deliveryAddress;
            }
        }

        public OrderChargeModel Calculate(int clientSubscriptionId, OrderSubscription orderSubscription)
        {
            _orderCharge = new OrderChargeModel
            {
                CookerId = _subscriptionHelper.GetCookerServingPriceModel(clientSubscriptionId).CookerId
            };
            var taxPercent = _subscriptionHelper.GetTaxPercent(_subscriptionHelper.GetCookerServingPriceModel(clientSubscriptionId).CookerId);
            _orderCharge.OrderTypeValue = Enum.GetName(typeof(OrderModelType.Values), orderSubscription.OrderTypeId);
            _orderCharge.PaymentMethodValue = Enum.GetName(typeof(PaymentMethodType.Values), orderSubscription.PaymentMethodId);
   
            #region PickUpOrderCharge

            //if (orderSubscription.OrderTypeId == (int)OrderType.Values.PickUp)
            //{
            //   _orderCharge = PickUpCharge(orderSubscription, taxPercent);
            //}

            #endregion

            #region DeliveryOrderCharge

            //var cookerDelieryZonesId = (from c in _cookerDeliveryZones where c.CookerId == cookerId select c.DeliveryId).ToList();

            //decimal deliveryFees = 0;
            //foreach (var deliveryZoneId in cookerDelieryZonesId)
            //{
            //    //Custom KML Function to see if the item is in the zone
            //    //Moq for now
            //    var deliveryzone = _deliveryZones.FirstOrDefault(c => c.DeliveryId == deliveryZoneId);

            //    //KML integration to see if deliveryaddress is Zone
            //    if (_deliveryAddress.AddressTypeId == (int) AddressToDeliveryZone.Values.AddressInZone)
            //    {
            //        if (deliveryzone != null)
            //        {
            //            deliveryFees = deliveryzone.DeliveryFees;
            //        }
            //    }
            //}

            //_orderCharge = DeliveryCharge(order, deliveryFees, taxPercent); 

            #endregion

            #region Neutral
            _orderCharge = Netural(orderSubscription, taxPercent);
            #endregion
   
            return _orderCharge;
        }

        #region Order Charges

        private OrderChargeModel PickUpCharge(OrderSubscription order, decimal? taxPercent)
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

        private OrderChargeModel DeliveryCharge(OrderSubscription order, decimal deliveryFee, decimal? taxPercent)
        {
            if (taxPercent == null)
            {
                taxPercent = 1;
            }
            return new OrderChargeModel
            {
                DeliveryFee = deliveryFee,
                SalesTaxes = new Money().RoundTo2Decimal((decimal)((order.SubTotal + deliveryFee) * taxPercent)/100),
                Subtotal = order.SubTotal,
                TotalCharges = new Money().RoundTo2Decimal(CalculateCharges(order, (decimal)(deliveryFee + (order.SubTotal + deliveryFee) * taxPercent) / 100 + order.SubTotal))
            };
        }

        private OrderChargeModel Netural(OrderSubscription order, decimal? taxPercent)
        {
            if (taxPercent == null)
            {
                taxPercent = 1;
            }
            return new OrderChargeModel
            {
                DeliveryFee = 0,
                SalesTaxes = new Money().RoundTo2Decimal((decimal)(order.SubTotal * taxPercent)/100),
                Subtotal = order.SubTotal,
                TotalCharges = new Money().RoundTo2Decimal(CalculateCharges(order, (decimal)(order.SubTotal * taxPercent) / 100 + order.SubTotal))
            };
        }

        #endregion

        #region Calculate Charges

        private decimal CalculateCharges(OrderSubscription order, decimal charges)
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
            var salesTaxCharges = (charges * taxes)/100;
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
            var promotion = new FakePromotions().MyPromotions.FirstOrDefault(x => x.PromotionId == promotionId);
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
            var coupon = new FakeCoupons().MyCoupons.FirstOrDefault(x => x.CouponId == couponId);
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
