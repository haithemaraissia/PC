using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Clients;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeClientOrderReviewSentRepository : FakeGenericRepository<ClientOrderReviewSent>, IClientOrderReviewSentRepository
    {
	    public FakeClientOrderReviewSentRepository(): base(new FakeClientOrdersReviewSent().MyClientOrdersReviewSent)
        {
        }

        public FakeClientOrderReviewSentRepository(List<ClientOrderReviewSent> myClientOrderReviewSents)
            : base(myClientOrderReviewSents)
        {
        }
    }
}
       