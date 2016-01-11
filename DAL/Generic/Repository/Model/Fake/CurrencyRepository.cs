using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Currencies;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCurrencyRepository : FakeGenericRepository<Currency>, ICurrencyRepository
    {
	    public FakeCurrencyRepository(): base(new FakeCurrencies().MyCurrencies)
        {
        }

        public FakeCurrencyRepository(List<Currency> myCurrencys)
            : base(myCurrencys)
        {
        }
    }
}
       