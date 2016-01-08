using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CurrencyRepository : FakeGenericRepository<Currency>, ICurrencyRepository
    {
	    public CurrencyRepository(): base(new FakeCurrencys().MyCurrencys)
        {
        }

        public CurrencyRepository(List<Currency> myCurrencys): base(myCurrencys)
        {
        }
    }
}
       