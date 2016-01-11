using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DAL.Fake.Model.GoodData.Invoices.Client.Client1;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders.Client1;
using DAL.Fake.Model.LookUp.OrderStatu;
using Model;

namespace DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrderHistory.Client1
{
    public class FakeClient1SubscriptionOrderHistory
    {
        public List<OrderSubscription> MyClient1SubscriptionOrders;
        public List<OrderSubscriptionHistroy> MyClient1SubscriptionOrdersHistory;

        public FakeClient1SubscriptionOrderHistory()
        {
            MyClient1SubscriptionOrders = new FakeClient1SubscriptionsOrder().MyOrders;
            InitializeClient1SubscriptionOrderHistoryList();
        }

        private void InitializeClient1SubscriptionOrderHistoryList()
        {
            MyClient1SubscriptionOrdersHistory = new List<OrderSubscriptionHistroy> {
                FirstOrderSubscriptionHistory()
            };
        }

        private OrderSubscriptionHistroy FirstOrderSubscriptionHistory()
        {
            var invoice = new FakeSubscriptionsInvoices().FirstSubscriptionInvoice();
            Debug.Assert(invoice.OrderId != null, "invoice.OrderId != null");

            var orderSubscription = MyClient1SubscriptionOrders.FirstOrDefault(x => x.OrderSubscriptionId ==
                                                                                    invoice.OrderId);

            Debug.Assert(orderSubscription != null, "OrderSubscription != null");
            
            var orderHistory = new OrderSubscriptionHistroy
            {
                OrderSubscriptionHistoryId = 1,
                OrderSubscriptionId = (int)invoice.OrderId,
                ClientId = invoice.ClientId,
                CookerId = invoice.ClientId,
                OrderTypeValue = invoice.OrderTypeValue,
                PaymentMethodValue = invoice.PaymentMethodValue,
                PromotionTitle = invoice.PromotionTitle,
                PromotionPrice = invoice.PromotionPrice,
                PromotionCurrencyId = invoice.PromotionCurrencyId,
                CouponTitle = invoice.CouponTitle,
                CouponPrice = invoice.CouponPrice,
                CouponCurrencyId = invoice.CouponCurrencyId,
                PlanTitle = invoice.PlanTitle,
                SalesTax = invoice.SalesTax,
                DeliveryFees = invoice.DeliveryFees,
                SubTotal = invoice.SubTotal,
                Total = invoice.Total,
                CurrencyId = invoice.CurrencyId,
                
                OrderStatusId = (int)OrderStatus.Values.History,
                ServingMeasurementId = orderSubscription.ServingMeasurementId,
                NumberofServingTotal = orderSubscription.NumberofServingTotal,
                ClientSubscriptionId = orderSubscription.ClientSubscriptionId
            };
            return orderHistory;
        }

        ~FakeClient1SubscriptionOrderHistory()
        {
            MyClient1SubscriptionOrdersHistory = null;
        }
    }
}
