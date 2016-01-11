using System.Collections.Generic;
using DAL.Fake.Model.GoodData.PaymentsHistory.Client1;

namespace DAL.Fake.Model.GoodData.PaymentsHistory
{
    public class FakePaymentsHistory
    {
        public List<global::Model.PaymentsHistory> MyPaymentsHistory;

        public FakePaymentsHistory()
        {
            InitializePaymentsHistoryList();
        }

        public void InitializePaymentsHistoryList()
        {
            MyPaymentsHistory = new List<global::Model.PaymentsHistory>();
            var clientPaymentsHistory = new FakeClients1PaymentsHistory().MyClients1PaymentsHistory;
            foreach (var payment in clientPaymentsHistory)
            {
                MyPaymentsHistory.Add(payment);
            }
            //Same for Cooker

        }

        ~FakePaymentsHistory()
        {
            MyPaymentsHistory = null;
        }
    }
}


