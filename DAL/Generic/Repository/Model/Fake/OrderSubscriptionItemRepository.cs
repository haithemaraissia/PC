using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderSubscriptionItemRepository : FakeGenericRepository<OrderSubscriptionItem>, IOrderSubscriptionItemRepository
    {
	    public OrderSubscriptionItemRepository(): base(new FakeOrderSubscriptionItems().MyOrderSubscriptionItems)
        {
        }

        public OrderSubscriptionItemRepository(List<OrderSubscriptionItem> myOrderSubscriptionItems): base(myOrderSubscriptionItems)
        {
        }
    }
}
       