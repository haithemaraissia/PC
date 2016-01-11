using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerRepository : FakeGenericRepository<Cooker>, ICookerRepository
    {
	    public FakeCookerRepository(): base(new FakeCookers().MyCookers)
        {
        }

        public FakeCookerRepository(List<Cooker> myCookers)
            : base(myCookers)
        {
        }
    }
}
       