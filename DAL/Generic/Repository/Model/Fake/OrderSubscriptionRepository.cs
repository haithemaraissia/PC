using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderSubscriptionRepository : FakeGenericRepository<OrderSubscription>, IOrderSubscriptionRepository
    {
	    public OrderSubscriptionRepository(): base(new FakeOrderSubscriptions().MyOrderSubscriptions)
        {
        }

        public OrderSubscriptionRepository(List<OrderSubscription> myOrderSubscriptions): base(myOrderSubscriptions)
        {
        }
    }
}
       