using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerMenuRepository : FakeGenericRepository<CookerMenu>, ICookerMenuRepository
    {
	    public FakeCookerMenuRepository(): base(new FakeCookerMenus().MyFakeCookerMenus)
        {
        }

        public FakeCookerMenuRepository(List<CookerMenu> myCookerMenus)
            : base(myCookerMenus)
        {
        }
    }
}
       