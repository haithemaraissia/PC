using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderItemDishOptionRepository : FakeGenericRepository<OrderItemDishOption>, IOrderItemDishOptionRepository
    {
	    public OrderItemDishOptionRepository(): base(new FakeOrderItemDishOptions().MyOrderItemDishOptions)
        {
        }

        public OrderItemDishOptionRepository(List<OrderItemDishOption> myOrderItemDishOptions): base(myOrderItemDishOptions)
        {
        }
    }
}
       