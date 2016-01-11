using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderStatuRepository : FakeGenericRepository<OrderStatu>, IOrderStatuRepository
    {
        public FakeOrderStatuRepository():base(Enum.GetValues(typeof(OrderStatu)).Cast<OrderStatu>().ToList())
        {
        }

        public FakeOrderStatuRepository(List<OrderStatu> myOrderStatus)
            : base(myOrderStatus)
        {
        }
    }
}
       