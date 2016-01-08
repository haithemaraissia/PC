using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerOrderReviewReceivedRepository : FakeGenericRepository<CookerOrderReviewReceived>, ICookerOrderReviewReceivedRepository
    {
	    public CookerOrderReviewReceivedRepository(): base(new FakeCookerOrderReviewReceiveds().MyCookerOrderReviewReceiveds)
        {
        }

        public CookerOrderReviewReceivedRepository(List<CookerOrderReviewReceived> myCookerOrderReviewReceiveds): base(myCookerOrderReviewReceiveds)
        {
        }
    }
}
       