using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Orders.Clients.Client1;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders;
using DAL.Fake.Model.Util.Orders;
using Model;

namespace DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsInvoices
{
    public class FakeSubscriptionsInvoices
    {
        public List<Order> MyOrders;
        public List<Invoice> MyInvoices;

        public FakeSubscriptionsInvoices()
        {
            InitializeInvoicesList();
        }

        public void InitializeInvoicesList()
        {
            MyInvoices = new List<Invoice> {
                FirstInvoice(), 
                SecondInvoice(),
                ThirdInvoices()
            };
        }

        #region Invoice for First Order 

        public Invoice FirstSubscriptionInvoice()
        {
            //TODO CHANGE IT TO REFLECT THE SUBSCRIPTION

            MyOrders = new List<Order>();
            var client1Orders = new FakeClient1SubscriptionsOrder().MyOrders;
            foreach (var order in client1Orders)
            {
                MyOrders.Add(order);
            }

            var firstOrder = MyOrders.FirstOrDefault();
            if (firstOrder == null) return null;
            var firstOrderCharge = new OrderCharge().Calculate(firstOrder);

            //Add it is is a subscriptions

            var firstOrderInvoice = new Invoice
            {


                InvoiceId = 10,

                OrderId = firstOrder.OrderId,
                ClientId = firstOrder.ClientId,
                OrderDate = firstOrder.OrderDate,
                DeliveryDate = firstOrder.DeliveryDate,
                CurrencyId = firstOrder.CurrencyId,

                CookerId = firstOrderCharge.CookerId,
                OrderTypeValue = firstOrderCharge.OrderTypeValue,
                PaymentMethodValue = firstOrderCharge.PaymentMethodValue,

                PromotionTitle = firstOrderCharge.PromotionTitle,
                PromotionPrice = firstOrderCharge.PromotionPrice,
                PromotionCurrencyId = firstOrderCharge.PromotionCurrencyId,

                CouponTitle = firstOrderCharge.CouponTitle,
                CouponPrice = firstOrderCharge.CouponPrice,
                CouponCurrencyId = firstOrderCharge.CouponCurrencyId,

                PlanTitle = firstOrderCharge.PlanTitle,
                SalesTax = firstOrderCharge.SalesTaxes,
                DeliveryFees = firstOrderCharge.DeliveryFee,
                SubTotal = firstOrderCharge.Subtotal,
                Total = firstOrderCharge.TotalCharges,

                OrderModelTypeId = 2,
                CookerSubscriptionId = null,
                ServingPriceId = null,
                PlanId = null

            };
            return firstOrderInvoice;
        }
        #endregion


        #region TO DO ANC COMPLETE
        public Invoice SecondInvoice()
        {
            return null;
        }

        public Invoice ThirdInvoices()
        {
            return null;
        }

        ~FakeSubscriptionsInvoices()
        {
            MyInvoices = null;
        }

        #endregion

    }
}
