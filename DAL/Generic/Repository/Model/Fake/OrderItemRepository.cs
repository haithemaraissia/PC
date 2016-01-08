using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderItemRepository : FakeGenericRepository<OrderItem>, IOrderItemRepository
    {
	    public OrderItemRepository(): base(new FakeOrderItems().MyOrderItems)
        {
        }

        public OrderItemRepository(List<OrderItem> myOrderItems): base(myOrderItems)
        {
        }
    }
}
       