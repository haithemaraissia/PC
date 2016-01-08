using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ClientReviewScoreRepository : FakeGenericRepository<ClientReviewScore>, IClientReviewScoreRepository
    {
	    public ClientReviewScoreRepository(): base(new FakeClientReviewScores().MyClientReviewScores)
        {
        }

        public ClientReviewScoreRepository(List<ClientReviewScore> myClientReviewScores): base(myClientReviewScores)
        {
        }
    }
}
       