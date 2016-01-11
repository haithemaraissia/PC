using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.OrderItemDishes;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderItemDishOptionRepository : FakeGenericRepository<OrderItemDishOption>, IOrderItemDishOptionRepository
    {
	    public FakeOrderItemDishOptionRepository(): base(new FakeOrderItemDishOptions().MyOrderItemDishOptions)
        {
        }

        public FakeOrderItemDishOptionRepository(List<OrderItemDishOption> myOrderItemDishOptions)
            : base(myOrderItemDishOptions)
        {
        }
    }
}
       