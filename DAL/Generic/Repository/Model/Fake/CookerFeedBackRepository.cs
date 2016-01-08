using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerFeedBackRepository : FakeGenericRepository<CookerFeedBack>, ICookerFeedBackRepository
    {
	    public CookerFeedBackRepository(): base(new FakeCookerFeedBacks().MyCookerFeedBacks)
        {
        }

        public CookerFeedBackRepository(List<CookerFeedBack> myCookerFeedBacks): base(myCookerFeedBacks)
        {
        }
    }
}
       