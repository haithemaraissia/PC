using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Dispute;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeDisputeReasonRepository : FakeGenericRepository<DisputeReason>, IDisputeReasonRepository
    {
	    public FakeDisputeReasonRepository(): base(new FakeDisputeReason().MyDisputeReasons)
        {
        }

        public FakeDisputeReasonRepository(List<DisputeReason> myDisputeReasons)
            : base(myDisputeReasons)
        {
        }
    }
}
       