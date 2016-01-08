using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderSubscriptionHistroyRepository : FakeGenericRepository<OrderSubscriptionHistroy>, IOrderSubscriptionHistroyRepository
    {
	    public OrderSubscriptionHistroyRepository(): base(new FakeOrderSubscriptionHistroys().MyOrderSubscriptionHistroys)
        {
        }

        public OrderSubscriptionHistroyRepository(List<OrderSubscriptionHistroy> myOrderSubscriptionHistroys): base(myOrderSubscriptionHistroys)
        {
        }
    }
}
       