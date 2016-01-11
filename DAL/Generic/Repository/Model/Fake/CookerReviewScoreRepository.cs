using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerReviewScoreRepository : FakeGenericRepository<CookerReviewScore>, ICookerReviewScoreRepository
    {
	    public FakeCookerReviewScoreRepository(): base(new FakeCookerReviewScore().MyCookerReviewScore)
        {
        }

        public FakeCookerReviewScoreRepository(List<CookerReviewScore> myCookerReviewScores)
            : base(myCookerReviewScores)
        {
        }
    }
}
       