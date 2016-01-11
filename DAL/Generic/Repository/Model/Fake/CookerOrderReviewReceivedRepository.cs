using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerOrderReviewReceivedRepository : FakeGenericRepository<CookerOrderReviewReceived>, ICookerOrderReviewReceivedRepository
    {
	    public FakeCookerOrderReviewReceivedRepository(): base(new FakeCookerOrdersReviewReceived().MyCookerOrdersReviewReceived)
        {
        }

        public FakeCookerOrderReviewReceivedRepository(List<CookerOrderReviewReceived> myCookerOrderReviewReceiveds)
            : base(myCookerOrderReviewReceiveds)
        {
        }
    }
}
       