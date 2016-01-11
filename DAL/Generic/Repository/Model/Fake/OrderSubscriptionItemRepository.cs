using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders.SubscriptionOrderItems;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderSubscriptionItemRepository : FakeGenericRepository<OrderSubscriptionItem>, IOrderSubscriptionItemRepository
    {
        public FakeOrderSubscriptionItemRepository() : base(new FakeOrderSubscriptionItems().MySubscriptionsOrderItems)
        {
        }

        public FakeOrderSubscriptionItemRepository(List<OrderSubscriptionItem> myOrderSubscriptionItems)
            : base(myOrderSubscriptionItems)
        {
        }
    }
}
       