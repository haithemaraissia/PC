using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderSubscriptionItemDishOptionRepository : FakeGenericRepository<OrderSubscriptionItemDishOption>, IOrderSubscriptionItemDishOptionRepository
    {
	    public OrderSubscriptionItemDishOptionRepository(): base(new FakeOrderSubscriptionItemDishOptions().MyOrderSubscriptionItemDishOptions)
        {
        }

        public OrderSubscriptionItemDishOptionRepository(List<OrderSubscriptionItemDishOption> myOrderSubscriptionItemDishOptions): base(myOrderSubscriptionItemDishOptions)
        {
        }
    }
}
       