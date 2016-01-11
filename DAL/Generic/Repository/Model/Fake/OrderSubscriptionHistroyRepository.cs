using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrderHistory;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderSubscriptionHistroyRepository : FakeGenericRepository<OrderSubscriptionHistroy>, IOrderSubscriptionHistroyRepository
    {
	    public FakeOrderSubscriptionHistroyRepository(): base(new FakeSubscriptionOrdersHistory().MySubscriptionOrdersHistory)
        {
        }

        public FakeOrderSubscriptionHistroyRepository(List<OrderSubscriptionHistroy> myOrderSubscriptionHistroys): base(myOrderSubscriptionHistroys)
        {
        }
    }
}
       