using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerSpokenLanguageRepository : FakeGenericRepository<CookerSpokenLanguage>, ICookerSpokenLanguageRepository
    {
	    public CookerSpokenLanguageRepository(): base(new FakeCookerSpokenLanguages().MyCookerSpokenLanguages)
        {
        }

        public CookerSpokenLanguageRepository(List<CookerSpokenLanguage> myCookerSpokenLanguages): base(myCookerSpokenLanguages)
        {
        }
    }
}
       