using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.OrdersHistory;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderHistroyRepository : FakeGenericRepository<OrderHistroy>, IOrderHistroyRepository
    {
        public FakeOrderHistroyRepository(): base(new FakeOrdersHistory().MyOrdersHistory)
        {
        }

        public FakeOrderHistroyRepository(List<OrderHistroy> myOrderHistroys)
            : base(myOrderHistroys)
        {
        }
    }
}
       