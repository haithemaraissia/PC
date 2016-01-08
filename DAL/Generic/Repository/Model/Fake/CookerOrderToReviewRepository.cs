using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerOrderToReviewRepository : FakeGenericRepository<CookerOrderToReview>, ICookerOrderToReviewRepository
    {
	    public CookerOrderToReviewRepository(): base(new FakeCookerOrderToReviews().MyCookerOrderToReviews)
        {
        }

        public CookerOrderToReviewRepository(List<CookerOrderToReview> myCookerOrderToReviews): base(myCookerOrderToReviews)
        {
        }
    }
}
       