using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.PaymentMethods;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakePaymentMethodRepository : FakeGenericRepository<PaymentMethod>, IPaymentMethodRepository
    {
	    public FakePaymentMethodRepository(): base(new FakePaymentMethods().MyPaymentMethods)
        {
        }

        public FakePaymentMethodRepository(List<PaymentMethod> myPaymentMethods)
            : base(myPaymentMethods)
        {
        }
    }
}
       