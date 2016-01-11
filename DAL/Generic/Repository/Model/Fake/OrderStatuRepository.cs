using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Generic;
using DAL.Fake.Model.LookUp.OrderStatu;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeOrderStatuRepository : FakeGenericRepository<OrderStatu>, IOrderStatuRepository
    {
        public FakeOrderStatuRepository():base(Enum.GetValues(typeof(OrderStatus.Values)).Cast<OrderStatu>().ToList())
        {
        }

        public FakeOrderStatuRepository(List<OrderStatu> myOrderStatus)
            : base(myOrderStatus)
        {
        }
    }
}
       