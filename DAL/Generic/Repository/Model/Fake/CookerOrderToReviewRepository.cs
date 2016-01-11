using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerOrderToReviewRepository : FakeGenericRepository<CookerOrderToReview>, ICookerOrderToReviewRepository
    {
	    public FakeCookerOrderToReviewRepository(): base(new FakeCookerOrderToReview().MyCookerOrderToReview)
        {
        }

        public FakeCookerOrderToReviewRepository(List<CookerOrderToReview> myCookerOrderToReviews)
            : base(myCookerOrderToReviews)
        {
        }
    }
}
       