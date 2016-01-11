using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderSubscriptionRepository : FakeGenericRepository<OrderSubscription>, IOrderSubscriptionRepository
    {
	    public FakeOrderSubscriptionRepository(): base(new FakeSubscriptionsOrder().MyOrderSubscriptions)
        {
        }

        public FakeOrderSubscriptionRepository(List<OrderSubscription> myOrderSubscriptions)
            : base(myOrderSubscriptions)
        {
        }
    }
}
       