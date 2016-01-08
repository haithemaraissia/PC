using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderHistroyRepository : FakeGenericRepository<OrderHistroy>, IOrderHistroyRepository
    {
	    public OrderHistroyRepository(): base(new FakeOrderHistroys().MyOrderHistroys)
        {
        }

        public OrderHistroyRepository(List<OrderHistroy> myOrderHistroys): base(myOrderHistroys)
        {
        }
    }
}
       