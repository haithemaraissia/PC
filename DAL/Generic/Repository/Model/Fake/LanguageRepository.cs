using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class LanguageRepository : FakeGenericRepository<Language>, ILanguageRepository
    {
	    public LanguageRepository(): base(new FakeLanguages().MyLanguages)
        {
        }

        public LanguageRepository(List<Language> myLanguages): base(myLanguages)
        {
        }
    }
}
       