using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders;
using DAL.Fake.Model.Util;
using DAL.Fake.Model.Util.Subscriptions;
using Model;

namespace DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsInvoices
{
    public class FakeSubscriptionsInvoices
    {
        public List<OrderSubscription> MySubscriptionsOrders;
        public List<Invoice> MyInvoices;

        public FakeSubscriptionsInvoices()
        {
            InitializeInvoicesList();
        }

        public void InitializeInvoicesList()
        {
            MyInvoices = new List<Invoice> {
                FirstSubscriptionInvoice()
            };
        }

        #region Invoice for First Subscription Order 

        public Invoice FirstSubscriptionInvoice()
        {
            MySubscriptionsOrders = new List<OrderSubscription>();
            var client1SubscriptionsOrders = new FakeClient1SubscriptionsOrder().MyOrders;
            foreach (var order in client1SubscriptionsOrders)
            {
                MySubscriptionsOrders.Add(order);
            }

            var firstSubscriptionOrder = MySubscriptionsOrders.FirstOrDefault();
            if (firstSubscriptionOrder == null) return null;

            var firstSubscriptionOrderCharge = new SubscriptionCharge().Calculate(firstSubscriptionOrder.OrderSubscriptionId);
            var firstSubscriptionOrderInvoice = new Invoice
            {

                InvoiceId = 20,

                #region Orders Fields
                OrderId = null,
                OrderDate = null,
                DeliveryDate = null,
                #endregion

                #region Subscription Fields

                SubscriptionStartDate = DateTime.Now.Date,
                SubscriptionEndDate = DateTime.Now.Date.AddMonths(1),
                SubscriptionInvoiceDate = DateTime.Now.Date,
                ClientSubscriptionId = firstSubscriptionOrder.ClientSubscriptionId,
                CookerSubscriptionId = new SubscriptionHelper().GetCookerServingPriceModel(firstSubscriptionOrder.ClientSubscriptionId).CookerId,
                ServingPriceId = new SubscriptionHelper().GetCookerServingPriceModel(firstSubscriptionOrder.ClientSubscriptionId).ServicePriceId,
                PlanId = firstSubscriptionOrder.PlanId,
                PlanTitle = Enum.GetName(typeof(Plans), firstSubscriptionOrder.PlanId),

                #endregion
               
                #region Common Fields

                ClientId = firstSubscriptionOrder.ClientId,
                CookerId = new SubscriptionHelper().GetCookerServingPriceModel(firstSubscriptionOrder.ClientSubscriptionId).CookerId,
                OrderModelTypeId = (int)Util.OrderModelType.Values.Subscription,
                OrderTypeValue = Util.OrderModelType.Values.Subscription.ToString(),
                PaymentMethodValue = Enum.GetName(typeof(PaymentMethodType), firstSubscriptionOrder.PaymentMethodId),
                CurrencyId = firstSubscriptionOrder.CurrencyId,

                PromotionTitle = firstSubscriptionOrderCharge.PromotionTitle,
                PromotionPrice = firstSubscriptionOrderCharge.PromotionPrice,
                PromotionCurrencyId = firstSubscriptionOrderCharge.PromotionCurrencyId,

                CouponTitle = firstSubscriptionOrderCharge.CouponTitle,
                CouponPrice = firstSubscriptionOrderCharge.CouponPrice,
                CouponCurrencyId = firstSubscriptionOrderCharge.CouponCurrencyId,

                SalesTax = firstSubscriptionOrderCharge.SalesTaxes,
                DeliveryFees = firstSubscriptionOrderCharge.DeliveryFee,
                SubTotal = firstSubscriptionOrderCharge.Subtotal,
                Total = firstSubscriptionOrderCharge.TotalCharges

                #endregion


            };
            return firstSubscriptionOrderInvoice;
        }
        #endregion

        ~FakeSubscriptionsInvoices()
        {
            MyInvoices = null;
        }



        
    }
}
