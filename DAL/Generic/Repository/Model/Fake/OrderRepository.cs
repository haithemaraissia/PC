using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Orders;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderRepository : FakeGenericRepository<Order>, IOrderRepository
    {
	    public FakeOrderRepository(): base(new FakeOrders().MyOrders)
        {
        }

        public FakeOrderRepository(List<Order> myOrders)
            : base(myOrders)
        {
        }
    }
}
       