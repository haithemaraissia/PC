using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Languages;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeLanguageRepository : FakeGenericRepository<Language>, ILanguageRepository
    {
	    public FakeLanguageRepository(): base(new FakeLanguage().MyLanguages)
        {
        }

        public FakeLanguageRepository(List<Language> myLanguages)
            : base(myLanguages)
        {
        }
    }
}
       