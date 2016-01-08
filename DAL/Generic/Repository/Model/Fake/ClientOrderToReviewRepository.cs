using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ClientOrderToReviewRepository : FakeGenericRepository<ClientOrderToReview>, IClientOrderToReviewRepository
    {
	    public ClientOrderToReviewRepository(): base(new FakeClientOrderToReviews().MyClientOrderToReviews)
        {
        }

        public ClientOrderToReviewRepository(List<ClientOrderToReview> myClientOrderToReviews): base(myClientOrderToReviews)
        {
        }
    }
}
       