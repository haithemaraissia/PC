using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Dispute;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeDisputeRepository : FakeGenericRepository<Dispute>, IDisputeRepository
    {
	    public FakeDisputeRepository(): base(new FakeDisputes().MyDisputes)
        {
        }

        public FakeDisputeRepository(List<Dispute> myDisputes)
            : base(myDisputes)
        {
        }
    }
}
       