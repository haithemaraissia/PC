using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.OrderItems;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderItemRepository : FakeGenericRepository<OrderItem>, IOrderItemRepository
    {
	    public FakeOrderItemRepository(): base(new FakeOrderItems().MyOrderItems)
        {
        }

        public FakeOrderItemRepository(List<OrderItem> myOrderItems)
            : base(myOrderItems)
        {
        }
    }
}
       