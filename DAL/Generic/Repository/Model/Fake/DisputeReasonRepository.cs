using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class DisputeReasonRepository : FakeGenericRepository<DisputeReason>, IDisputeReasonRepository
    {
	    public DisputeReasonRepository(): base(new FakeDisputeReasons().MyDisputeReasons)
        {
        }

        public DisputeReasonRepository(List<DisputeReason> myDisputeReasons): base(myDisputeReasons)
        {
        }
    }
}
       