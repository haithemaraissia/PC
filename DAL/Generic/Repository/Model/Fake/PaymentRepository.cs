using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Payments;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakePaymentRepository : FakeGenericRepository<Payment>, IPaymentRepository
    {
        public FakePaymentRepository() : base(new FakePayments().MyPayments)
        {
        }

        public FakePaymentRepository(List<Payment> myPayments) : base(myPayments)
        {
        }
    }
}
