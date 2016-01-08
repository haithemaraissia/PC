using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class MenuSectionRepository : FakeGenericRepository<MenuSection>, IMenuSectionRepository
    {
	    public MenuSectionRepository(): base(new FakeMenuSections().MyMenuSections)
        {
        }

        public MenuSectionRepository(List<MenuSection> myMenuSections): base(myMenuSections)
        {
        }
    }
}
       