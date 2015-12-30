using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Clients;
using Model;

namespace DAL.Fake.Model
{
    public class FakeClientPayments
    {
        public List<Payment> MyClientPayments;

        public FakeClientPayments()
        {
            InitializeClientPaymentsList();
        }

        public void InitializeClientPaymentsList()
        {
            MyClientPayments = new List<Payment>();
            var client1Payments = new FakeClients1Payments().MyClients1Payments;
            foreach (var payment in client1Payments)
            {
                MyClientPayments.Add(payment);
            }
            //var client2Payments = new FakeClients2Payments().MyClients2Payments;
            //foreach (var payment in client2Payments)
            //{
            //    MyClientPayments.Add(payment);
            //}
            //var client3Payments = new FakeClients3Payments().MyClients3Payments;
            //foreach (var payment in client3Payments)
            //{
            //    MyClientPayments.Add(payment);
            //}

        }

        ~FakeClientPayments()
        {
            MyClientPayments = null;
        }
    }
}
