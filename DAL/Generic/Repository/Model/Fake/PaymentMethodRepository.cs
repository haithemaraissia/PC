using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class PaymentMethodRepository : FakeGenericRepository<PaymentMethod>, IPaymentMethodRepository
    {
	    public PaymentMethodRepository(): base(new FakePaymentMethods().MyPaymentMethods)
        {
        }

        public PaymentMethodRepository(List<PaymentMethod> myPaymentMethods): base(myPaymentMethods)
        {
        }
    }
}
       