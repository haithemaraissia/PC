using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using DAL.Fake.Model.GoodData.Cooker;
using DAL.Fake.Model.GoodData.CookerSubscriptions;
using DAL.Fake.Model.GoodData.Coupon;
using DAL.Fake.Model.GoodData.DeliveryZones;
using DAL.Fake.Model.GoodData.Orders.Clients;
using DAL.Fake.Model.GoodData.OrderTypes;
using DAL.Fake.Model.GoodData.PaymentMethods;
using DAL.Fake.Model.GoodData.Plan;
using DAL.Fake.Model.GoodData.Promotions;
using DAL.Fake.Model.KMLHelper;
using Model;
using Model.Helper;

namespace DAL.Fake.Model.Util.Orders
{
    public class SubscriptionCharge
    {
        private readonly List<Cooker> _cookers;
        private readonly List<OrderItem> _orderItem;
        private readonly List<DeliveryZone> _deliveryZones;
        private readonly List<CookerDeliveryZone> _cookerDeliveryZones;
        private readonly ClientAddress _deliveryAddress;
        private readonly List<PaymentMethod> _fakePaymentMethods;
        private readonly List<global::Model.OrderType> _fakeOrderTypes;
        private readonly List<Plan> _fakePlans;
        private List<ClientSubscription> FakeClientSubscription = new FakeClientSubscription().MyClientSubscriptions;
        private List<CookerSubscription> FakeCookerSubscription = new FakeCookerSubscriptions().MyCookerSubscriptions;
        private OrderChargeModel _orderCharge;

        public SubscriptionCharge(ClientAddress deliveryAddress = null)
        {
            _cookers = new FakeCookers().MyCookers;
            _orderItem = new FakeOrderItems().MyOrderItems;
            _deliveryZones = new FakeDeliveryZone().MyDeliveryZones;
            _cookerDeliveryZones = new FakeCookerDeliveryZone().MyCookerDeliveryZones;
            _fakePaymentMethods = new FakePaymentMethods().MyPaymentMethods;
            _fakeOrderTypes = new FakeOrderTypes().MyOrderTypes;
            _fakePlans = new FakePlans().MyPlans;

            if (deliveryAddress != null)
            {
                _deliveryAddress = deliveryAddress;
            }
        }

        public OrderChargeModel Calculate(int clientSubscriptionId)
        {
            var clientSubscription = (from c in FakeClientSubscription where c.ClientSubscriptionId == clientSubscriptionId select c).FirstOrDefault();

            var cookerSubscription =  (from c in FakeCookerSubscription where c.CookerSubscriptionId == clientSubscription.CookerSubscriptionId select c).FirstOrDefault();

#region ToDo Get the subscription Price
            //            var orderItems = (from c in _orderItem where c.OrderId == order.OrderId select c).ToList();
            //var cookerId = orderItems.First().CookerId;
            //var taxPercent = (from c in _cookers where c.CookerId == cookerId select c.TaxPercent).FirstOrDefault() ?? 1;
            //var paymentMethodValue = (from c in _fakePaymentMethods where c.PaymentMethodId == order.PaymentMethodId select c.PaymentMethodValue).FirstOrDefault();
            //var orderTypeValue = (from c in _fakeOrderTypes where c.OrderTypeId == order.OrderTypeId select c.OrderTypeValue).FirstOrDefault();
            //var planTitle = (from c in _fakePlans where c.PlanId == order.PlanId select c.Description).FirstOrDefault();

#endregion
            var orderItems = (from c in _orderItem select c).ToList().FirstOrDefault();
            var cookerId = orderItems.CookerId;
            var taxPercent = (from c in _cookers where c.CookerId == cookerId select c.TaxPercent).FirstOrDefault() ?? 1;
            var paymentMethodValue = (from c in _fakePaymentMethods select c).ToList().FirstOrDefault().PaymentMethodValue;
            var orderTypeValue = (from c in _fakeOrderTypes select c).ToList().FirstOrDefault().OrderTypeValue;
            var planTitle = (from c in _fakePlans select c).ToList().FirstOrDefault().Title;
           

            //#region PickUpOrderCharge

            //if (order.OrderTypeId == (int)OrderType.Values.PickUp)
            //{
            //   _orderCharge = PickUpCharge(order, taxPercent);
            //}

            //#endregion
 
            //#region DeliveryOrderCharge

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

            //#endregion


            #region SubscriptionFields

            _orderCharge.SubscriptionInvoiceDate = DateTime.Today.Date;


            #endregion

            _orderCharge.CookerId = cookerId;
            _orderCharge.PaymentMethodValue = paymentMethodValue;
            _orderCharge.OrderTypeValue = orderTypeValue;
            _orderCharge.SalesTaxes = CalculateSalesTax(_orderCharge.TotalCharges, taxPercent);
            _orderCharge.PlanTitle = planTitle;
            return _orderCharge;
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
                SalesTaxes = (decimal) (order.SubTotal * taxPercent),
                Subtotal = order.SubTotal,
                TotalCharges = CalculateCharges(order,(decimal) (order.SubTotal * taxPercent)+ order.SubTotal)
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
                SalesTaxes = (decimal) ((order.SubTotal + deliveryFee) * taxPercent),
                Subtotal = order.SubTotal,
                TotalCharges = CalculateCharges(order,(decimal)(deliveryFee + (order.SubTotal + deliveryFee) * taxPercent) + order.SubTotal)
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
            var salesTaxCharges = charges*taxes;
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
