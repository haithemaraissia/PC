using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class PaymentRepository : FakeGenericRepository<Payment>, IPaymentRepository
    {
	    public PaymentRepository(): base(new FakePayments().MyPayments)
        {
        }

        public PaymentRepository(List<Payment> myPayments): base(myPayments)
        {
        }
    }
}
       