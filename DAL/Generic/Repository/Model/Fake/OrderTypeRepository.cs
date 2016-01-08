using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderTypeRepository : FakeGenericRepository<OrderType>, IOrderTypeRepository
    {
	    public OrderTypeRepository(): base(new FakeOrderTypes().MyOrderTypes)
        {
        }

        public OrderTypeRepository(List<OrderType> myOrderTypes): base(myOrderTypes)
        {
        }
    }
}
       