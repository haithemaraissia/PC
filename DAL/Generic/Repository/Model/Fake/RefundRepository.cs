using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class RefundRepository : FakeGenericRepository<Refund>, IRefundRepository
    {
	    public RefundRepository(): base(new FakeRefunds().MyRefunds)
        {
        }

        public RefundRepository(List<Refund> myRefunds): base(myRefunds)
        {
        }
    }
}
       