using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Coupon;
using DAL.Fake.Model.GoodData.Promotions;
using Model;
using Model.Helper;

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
        private readonly OrderChargeModel _orderCharge;
        private readonly SubscriptionHelper _subscriptionHelper;
        #endregion


        #endregion

        public SubscriptionCharge(ClientAddress deliveryAddress = null)
        {
            _subscriptionHelper = new SubscriptionHelper();
            _orderCharge= new OrderChargeModel();
            if (deliveryAddress != null)
            {
                _deliveryAddress = deliveryAddress;
            }
        }

        public OrderChargeModel Calculate(int clientSubscriptionId, OrderSubscription orderSubscription)
        {
            _orderCharge.CookerId = _subscriptionHelper.GetCookerServingPriceModel(clientSubscriptionId).CookerId;
            var taxPercent = _subscriptionHelper.GetTaxPercent(_subscriptionHelper.GetCookerServingPriceModel(clientSubscriptionId).CookerId);
            _orderCharge.OrderTypeValue = Enum.GetName(typeof(OrderModelType), orderSubscription.OrderTypeId);
            _orderCharge.PaymentMethodValue = Enum.GetName(typeof(PaymentMethodType), orderSubscription.PaymentMethodId);
   
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

           _orderCharge.SalesTaxes = CalculateSalesTax(_orderCharge.TotalCharges, taxPercent);
   
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
                SalesTaxes = (decimal)(order.SubTotal * taxPercent),
                Subtotal = order.SubTotal,
                TotalCharges = CalculateCharges(order, (decimal)(order.SubTotal * taxPercent) + order.SubTotal)
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
                SalesTaxes = (decimal)((order.SubTotal + deliveryFee) * taxPercent),
                Subtotal = order.SubTotal,
                TotalCharges = CalculateCharges(order, (decimal)(deliveryFee + (order.SubTotal + deliveryFee) * taxPercent) + order.SubTotal)
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
