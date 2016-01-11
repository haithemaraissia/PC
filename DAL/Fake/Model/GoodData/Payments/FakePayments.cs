using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Payments.Clients;
using Model;

namespace DAL.Fake.Model.GoodData.Payments
{
    public class FakePayments
    {
        public List<Payment> MyPayments;

        public FakePayments()
        {
            InitializePaymentsList();
        }

        public void InitializePaymentsList()
        {
            MyPayments = new List<Payment>();
            var clientPayments = new FakeClientPayments().MyClientPayments;
            foreach (var payment in clientPayments)
            {
                MyPayments.Add(payment);
            }
            //Same for Cooker

        }

        ~FakePayments()
        {
            MyPayments = null;
        }
    }
}
