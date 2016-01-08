using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerOrderReviewSentRepository : FakeGenericRepository<CookerOrderReviewSent>, ICookerOrderReviewSentRepository
    {
	    public CookerOrderReviewSentRepository(): base(new FakeCookerOrderReviewSents().MyCookerOrderReviewSents)
        {
        }

        public CookerOrderReviewSentRepository(List<CookerOrderReviewSent> myCookerOrderReviewSents): base(myCookerOrderReviewSents)
        {
        }
    }
}
       