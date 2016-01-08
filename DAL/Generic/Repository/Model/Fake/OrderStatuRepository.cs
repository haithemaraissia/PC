using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class OrderStatuRepository : FakeGenericRepository<OrderStatu>, IOrderStatuRepository
    {
	    public OrderStatuRepository(): base(new FakeOrderStatus().MyOrderStatus)
        {
        }

        public OrderStatuRepository(List<OrderStatu> myOrderStatus): base(myOrderStatus)
        {
        }
    }
}
       