using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderModelTypeRepository : FakeGenericRepository<OrderModelType>, IOrderModelTypeRepository
    {
	    public OrderModelTypeRepository(): base(new FakeOrderModelTypes().MyOrderModelTypes)
        {
        }

        public OrderModelTypeRepository(List<OrderModelType> myOrderModelTypes): base(myOrderModelTypes)
        {
        }
    }
}
       