using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.OrderModelType;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderModelTypeRepository : FakeGenericRepository<OrderModelType>, IOrderModelTypeRepository
    {
	    public FakeOrderModelTypeRepository(): base(new FakeOrderModelTypes().MyOrderModelTypeTypes)
        {
        }

        public FakeOrderModelTypeRepository(List<OrderModelType> myOrderModelTypes)
            : base(myOrderModelTypes)
        {
        }
    }
}
       