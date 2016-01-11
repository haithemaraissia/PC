using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Dispute;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeDisputeStatuRepository : FakeGenericRepository<DisputeStatu>, IDisputeStatuRepository
    {
	    public FakeDisputeStatuRepository(): base(new FakeDisputeStatus().MyDisputeStatus)
        {
        }

        public FakeDisputeStatuRepository(List<DisputeStatu> myDisputeStatus)
            : base(myDisputeStatus)
        {
        }
    }
}
       