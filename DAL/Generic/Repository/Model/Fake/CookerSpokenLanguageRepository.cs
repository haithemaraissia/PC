using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerSpokenLanguageRepository : FakeGenericRepository<CookerSpokenLanguage>, ICookerSpokenLanguageRepository
    {
	    public FakeCookerSpokenLanguageRepository(): base(new FakeCookerSpokenLanguage().MyCookerSpokenLanguages)
        {
        }

        public FakeCookerSpokenLanguageRepository(List<CookerSpokenLanguage> myCookerSpokenLanguages)
            : base(myCookerSpokenLanguages)
        {
        }
    }
}
       