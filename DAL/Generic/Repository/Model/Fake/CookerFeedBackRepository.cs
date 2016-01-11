using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerFeedBackRepository : FakeGenericRepository<CookerFeedBack>, ICookerFeedBackRepository
    {
	    public FakeCookerFeedBackRepository(): base(new FakeCookerFeedbacks().MyCookersFakeCookerFeedbacks)
        {
        }

        public FakeCookerFeedBackRepository(List<CookerFeedBack> myCookerFeedBacks)
            : base(myCookerFeedBacks)
        {
        }
    }
}
       