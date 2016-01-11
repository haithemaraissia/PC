using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerPaymentMethodRepository : FakeGenericRepository<CookerPaymentMethod>, ICookerPaymentMethodRepository
    {
	    public FakeCookerPaymentMethodRepository(): base(new FakeCookerPaymentMethods().MyCookerPaymentMethods)
        {
        }

        public FakeCookerPaymentMethodRepository(List<CookerPaymentMethod> myCookerPaymentMethods)
            : base(myCookerPaymentMethods)
        {
        }
    }
}
       