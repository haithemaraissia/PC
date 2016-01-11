using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrderHistory.Client1;
using Model;

namespace DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrderHistory
{
    public class FakeSubscriptionOrdersHistory
    {
      public List<OrderSubscriptionHistroy> MySubscriptionOrdersHistory;


      public FakeSubscriptionOrdersHistory()
        {

            InitializeSubscriptionOrderHistoryList();
        }

        private void InitializeSubscriptionOrderHistoryList()
        {
            MySubscriptionOrdersHistory = new List<OrderSubscriptionHistroy>();
            var client1OSubscriptionOrdersHistory = new FakeClient1SubscriptionOrderHistory().MyClient1SubscriptionOrdersHistory;

            foreach (var subscriptionOrderHistory in client1OSubscriptionOrdersHistory)
            {
                MySubscriptionOrdersHistory.Add(subscriptionOrderHistory);
            }
        }

        ~FakeSubscriptionOrdersHistory()
        {
            MySubscriptionOrdersHistory = null;
        }
    }
}
