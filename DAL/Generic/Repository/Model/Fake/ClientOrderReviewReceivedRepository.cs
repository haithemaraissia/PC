using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Clients;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeClientOrderReviewReceivedRepository : FakeGenericRepository<ClientOrderReviewReceived>, IClientOrderReviewReceivedRepository
    {
	    public FakeClientOrderReviewReceivedRepository(): base(new FakeClientOrdersReviewReceived().MyClientOrdersReviewReceived)
        {
        }

        public FakeClientOrderReviewReceivedRepository(List<ClientOrderReviewReceived> myClientOrderReviewReceiveds)
            : base(myClientOrderReviewReceiveds)
        {
        }
    }
}
       