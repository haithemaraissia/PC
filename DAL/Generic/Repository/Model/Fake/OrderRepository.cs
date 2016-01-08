using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderRepository : FakeGenericRepository<Order>, IOrderRepository
    {
	    public OrderRepository(): base(new FakeOrders().MyOrders)
        {
        }

        public OrderRepository(List<Order> myOrders): base(myOrders)
        {
        }
    }
}
       