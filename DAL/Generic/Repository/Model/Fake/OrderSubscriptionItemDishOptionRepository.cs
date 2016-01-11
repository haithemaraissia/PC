using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders.SubscriptionOrderItems.SubscriptionOrderItemDishOptions;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderSubscriptionItemDishOptionRepository : FakeGenericRepository<OrderSubscriptionItemDishOption>, IOrderSubscriptionItemDishOptionRepository
    {
        public FakeOrderSubscriptionItemDishOptionRepository(): base(new FakeSubscriptionOrderItemDishOptions().MySubscriptionOrderItemDishOptions)
        {
        }

        public FakeOrderSubscriptionItemDishOptionRepository(List<OrderSubscriptionItemDishOption> myOrderSubscriptionItemDishOptions)
            : base(myOrderSubscriptionItemDishOptions)
        {
        }
    }
}
       