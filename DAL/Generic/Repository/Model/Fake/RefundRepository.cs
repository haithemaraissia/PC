using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Refunds;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeRefundRepository : FakeGenericRepository<Refund>, IRefundRepository
    {
	    public FakeRefundRepository(): base(new FakeRefunds().MyRefunds)
        {
        }

        public FakeRefundRepository(List<Refund> myRefunds)
            : base(myRefunds)
        {
        }
    }
}
       