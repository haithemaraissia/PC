using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.OrderTypes;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderTypeRepository : FakeGenericRepository<OrderType>, IOrderTypeRepository
    {
	    public FakeOrderTypeRepository(): base(new FakeOrderTypes().MyOrderTypes)
        {
        }

        public FakeOrderTypeRepository(List<OrderType> myOrderTypes)
            : base(myOrderTypes)
        {
        }
    }
}
       