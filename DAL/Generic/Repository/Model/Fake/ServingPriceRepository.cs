using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Subscriptions.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeServingPriceRepository : FakeGenericRepository<ServingPrice>, IServingPriceRepository
    {
	    public FakeServingPriceRepository(): base(new FakeServingPrices().MyServingPricings)
        {
        }

        public FakeServingPriceRepository(List<ServingPrice> myServingPrices)
            : base(myServingPrices)
        {
        }
    }
}
       