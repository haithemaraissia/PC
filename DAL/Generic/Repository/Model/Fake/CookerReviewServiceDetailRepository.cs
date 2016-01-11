using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerReviewServiceDetailRepository : FakeGenericRepository<CookerReviewServiceDetail>, ICookerReviewServiceDetailRepository
    {
	    public FakeCookerReviewServiceDetailRepository(): base(new FakeCookerReviewServiceDetails().MyCookerReviewServiceDetails)
        {
        }

        public FakeCookerReviewServiceDetailRepository(List<CookerReviewServiceDetail> myCookerReviewServiceDetails)
            : base(myCookerReviewServiceDetails)
        {
        }
    }
}
       