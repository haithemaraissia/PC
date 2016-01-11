using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeMenuSectionRepository : FakeGenericRepository<MenuSection>, IMenuSectionRepository
    {
	    public FakeMenuSectionRepository(): base(new FakeMenuSection().MyMenuSections)
        {
        }

        public FakeMenuSectionRepository(List<MenuSection> myMenuSections)
            : base(myMenuSections)
        {
        }
    }
}
       