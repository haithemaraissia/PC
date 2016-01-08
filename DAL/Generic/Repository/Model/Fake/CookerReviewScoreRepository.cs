using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerReviewScoreRepository : FakeGenericRepository<CookerReviewScore>, ICookerReviewScoreRepository
    {
	    public CookerReviewScoreRepository(): base(new FakeCookerReviewScores().MyCookerReviewScores)
        {
        }

        public CookerReviewScoreRepository(List<CookerReviewScore> myCookerReviewScores): base(myCookerReviewScores)
        {
        }
    }
}
       