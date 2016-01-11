using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders.Client1;
using Model;

namespace DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders
{
    public class FakeSubscriptionsOrder
    {
        public List<OrderSubscription> MyOrderSubscriptions;

        public FakeSubscriptionsOrder()
        {
            InitializerderSubscriptionList();
        }

        private void InitializerderSubscriptionList()
        {
           MyOrderSubscriptions = new List<OrderSubscription>();
            var client1OrderSubscriptions = new FakeClient1SubscriptionsOrder().MyOrders;

            foreach (var subscriptionOrder in client1OrderSubscriptions)
            {
                MyOrderSubscriptions.Add(subscriptionOrder);
            }
        }

       ~ FakeSubscriptionsOrder()
        {
            MyOrderSubscriptions = null;
        }
    }
}
