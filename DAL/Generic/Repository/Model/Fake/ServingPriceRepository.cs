using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ServingPriceRepository : FakeGenericRepository<ServingPrice>, IServingPriceRepository
    {
	    public ServingPriceRepository(): base(new FakeServingPrices().MyServingPrices)
        {
        }

        public ServingPriceRepository(List<ServingPrice> myServingPrices): base(myServingPrices)
        {
        }
    }
}
       