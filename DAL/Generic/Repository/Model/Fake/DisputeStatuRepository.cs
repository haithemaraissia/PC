using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class DisputeStatuRepository : FakeGenericRepository<DisputeStatu>, IDisputeStatuRepository
    {
	    public DisputeStatuRepository(): base(new FakeDisputeStatus().MyDisputeStatus)
        {
        }

        public DisputeStatuRepository(List<DisputeStatu> myDisputeStatus): base(myDisputeStatus)
        {
        }
    }
}
       