using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class PaymentsHistoryRepository : FakeGenericRepository<PaymentsHistory>, IPaymentsHistoryRepository
    {
	    public PaymentsHistoryRepository(): base(new FakePaymentsHistorys().MyPaymentsHistorys)
        {
        }

        public PaymentsHistoryRepository(List<PaymentsHistory> myPaymentsHistorys): base(myPaymentsHistorys)
        {
        }
    }
}
       