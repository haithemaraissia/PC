using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders;
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
            var subscriptionHelper = new SubscriptionHelper();
            var firstSubscriptionOrderCharge = new SubscriptionCharge().Calculate(firstSubscriptionOrder.OrderSubscriptionId, firstSubscriptionOrder);
               
            var firstSubscriptionOrderInvoice = new Invoice
            {

                InvoiceId = 20,

                #region Orders Fields
                //OrderId = null,
                OrderDate = null,
                DeliveryDate = null,
                #endregion

                #region Subscription Fields
                OrderId = firstSubscriptionOrder.OrderSubscriptionId,
                SubscriptionStartDate = DateTime.Now.Date,
                SubscriptionEndDate = DateTime.Now.Date.AddMonths(1),
                SubscriptionInvoiceDate = DateTime.Now.Date,

                ClientSubscriptionId = firstSubscriptionOrder.ClientSubscriptionId,
                CookerSubscriptionId = subscriptionHelper.GetCookerSubscription(firstSubscriptionOrder.ClientSubscriptionId).CookerSubscriptionId,
                ServingPriceId = subscriptionHelper.GetCookerServingPriceModel(firstSubscriptionOrder.ClientSubscriptionId).ServicePriceId,
                PlanId = firstSubscriptionOrder.PlanId,
                PlanTitle = subscriptionHelper.GetPlanTitle(firstSubscriptionOrder.PlanId),

                #endregion
               
                #region Common Fields

                ClientId = firstSubscriptionOrder.ClientId,
                CookerId = firstSubscriptionOrderCharge.CookerId,

                OrderModelTypeId = firstSubscriptionOrder.OrderTypeId,
                OrderTypeValue = firstSubscriptionOrderCharge.OrderTypeValue,

                PaymentMethodValue = firstSubscriptionOrderCharge.PaymentMethodValue,
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
