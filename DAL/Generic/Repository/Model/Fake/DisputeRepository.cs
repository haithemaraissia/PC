using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class DisputeRepository : FakeGenericRepository<Dispute>, IDisputeRepository
    {
	    public DisputeRepository(): base(new FakeDisputes().MyDisputes)
        {
        }

        public DisputeRepository(List<Dispute> myDisputes): base(myDisputes)
        {
        }
    }
}
       