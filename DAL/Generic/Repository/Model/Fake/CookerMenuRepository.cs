using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerMenuRepository : FakeGenericRepository<CookerMenu>, ICookerMenuRepository
    {
	    public CookerMenuRepository(): base(new FakeCookerMenus().MyCookerMenus)
        {
        }

        public CookerMenuRepository(List<CookerMenu> myCookerMenus): base(myCookerMenus)
        {
        }
    }
}
       