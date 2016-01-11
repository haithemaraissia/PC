using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerOrderReviewSentRepository : FakeGenericRepository<CookerOrderReviewSent>, ICookerOrderReviewSentRepository
    {
	    public FakeCookerOrderReviewSentRepository(): base(new FakeCookerOrdersReviewSent().MyCookerOrdersReviewSent)
        {
        }

        public FakeCookerOrderReviewSentRepository(List<CookerOrderReviewSent> myCookerOrderReviewSents)
            : base(myCookerOrderReviewSents)
        {
        }
    }
}
       