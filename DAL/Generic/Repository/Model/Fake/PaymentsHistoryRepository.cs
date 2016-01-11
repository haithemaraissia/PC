using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.PaymentsHistory;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakePaymentsHistoryRepository : FakeGenericRepository<PaymentsHistory>, IPaymentsHistoryRepository
    {
	    public FakePaymentsHistoryRepository(): base(new FakePaymentsHistory().MyPaymentsHistory)
        {
        }

        public FakePaymentsHistoryRepository(List<PaymentsHistory> myPaymentsHistorys)
            : base(myPaymentsHistorys)
        {
        }
    }
}
       