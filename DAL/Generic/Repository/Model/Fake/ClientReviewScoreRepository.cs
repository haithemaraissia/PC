using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Clients;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeClientReviewScoreRepository : FakeGenericRepository<ClientReviewScore>, IClientReviewScoreRepository
    {
	    public FakeClientReviewScoreRepository(): base(new FakeClientReviewScore().MyClientReviewScore)
        {
        }

        public FakeClientReviewScoreRepository(List<ClientReviewScore> myClientReviewScores)
            : base(myClientReviewScores)
        {
        }
    }
}
       