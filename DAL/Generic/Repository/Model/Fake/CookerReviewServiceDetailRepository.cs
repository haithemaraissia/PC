using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerReviewServiceDetailRepository : FakeGenericRepository<CookerReviewServiceDetail>, ICookerReviewServiceDetailRepository
    {
	    public CookerReviewServiceDetailRepository(): base(new FakeCookerReviewServiceDetails().MyCookerReviewServiceDetails)
        {
        }

        public CookerReviewServiceDetailRepository(List<CookerReviewServiceDetail> myCookerReviewServiceDetails): base(myCookerReviewServiceDetails)
        {
        }
    }
}
       