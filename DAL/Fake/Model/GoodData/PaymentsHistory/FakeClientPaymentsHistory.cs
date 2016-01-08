using System.Collections.Generic;
using DAL.Fake.Model.GoodData.PaymentsHistory.Client1;

namespace DAL.Fake.Model.GoodData.PaymentsHistory
{
    public class FakeClientPaymentsHistory
    {
        public List<global::Model.PaymentsHistory> MyClientPaymentsHistory;

        public FakeClientPaymentsHistory()
        {
            InitializeClientPaymentsHistoryList();
        }

        public void InitializeClientPaymentsHistoryList()
        {
            MyClientPaymentsHistory = new List<global::Model.PaymentsHistory>();
            var client1PaymentsHistory = new FakeClients1PaymentsHistory().MyClients1PaymentsHistory;
            foreach (var payment in client1PaymentsHistory)
            {
                MyClientPaymentsHistory.Add(payment);
            }
            //var client2PaymentsHistory = new FakeClients2PaymentsHistory().MyClients2PaymentsHistory;
            //foreach (var payment in client2PaymentsHistory)
            //{
            //    MyClientPaymentsHistory.Add(payment);
            //}
            //var client3PaymentsHistory = new FakeClients3PaymentsHistory().MyClients3PaymentsHistory;
            //foreach (var payment in client3PaymentsHistory)
            //{
            //    MyClientPaymentsHistory.Add(payment);
            //}

        }

        ~FakeClientPaymentsHistory()
        {
            MyClientPaymentsHistory = null;
        }
    }
}
