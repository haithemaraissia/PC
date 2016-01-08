using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerRepository : FakeGenericRepository<Cooker>, ICookerRepository
    {
	    public CookerRepository(): base(new FakeCookers().MyCookers)
        {
        }

        public CookerRepository(List<Cooker> myCookers): base(myCookers)
        {
        }
    }
}
       