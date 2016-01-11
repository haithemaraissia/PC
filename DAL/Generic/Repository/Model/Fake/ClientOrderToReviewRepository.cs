using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Clients;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeClientOrderToReviewRepository : FakeGenericRepository<ClientOrderToReview>, IClientOrderToReviewRepository
    {
	    public FakeClientOrderToReviewRepository(): base(new FakeClientOrderToReview().MyClientOrderToReview)
        {
        }

        public FakeClientOrderToReviewRepository(List<ClientOrderToReview> myClientOrderToReviews)
            : base(myClientOrderToReviews)
        {
        }
    }
}
       