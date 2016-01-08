using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerPaymentMethodRepository : FakeGenericRepository<CookerPaymentMethod>, ICookerPaymentMethodRepository
    {
	    public CookerPaymentMethodRepository(): base(new FakeCookerPaymentMethods().MyCookerPaymentMethods)
        {
        }

        public CookerPaymentMethodRepository(List<CookerPaymentMethod> myCookerPaymentMethods): base(myCookerPaymentMethods)
        {
        }
    }
}
       