using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace DAL.Fake.Model.GoodData.Clients
{
    public class FakeClients1Payments
    {
        public List<Payment> MyClients1Payments;

        public FakeClients1Payments()
        {
            InitializeClients1PaymentsList();
        }

        public void InitializeClients1PaymentsList()
        {
            MyClients1Payments = new List<Payment> {
                FirstClient1Payment(), 
                SecondClient1Payment(),
                ThirdClient1Payment()
            };
        }

        public Payment FirstClient1Payment()
        {
            var FirstInvoice = new FakeClient1Invoices().FirstInvoice();
            if (FirstInvoice.OrderId != null)
            {
                var Payment = new Payment
                {
                    PaymentId = 1,
                    InvoiceId = FirstInvoice.InvoiceId,
                    PaymentDate = DateTime.Now.Date,
                    PaymentAmount = FirstInvoice.Total,
                    OrderId = (int) FirstInvoice.OrderId,
                    ClientId = FirstInvoice.ClientId,
                    CookerId = FirstInvoice.CookerId,
                    TransactionId = "G126F85"
                };


                return Payment;
            }
            return null;
        }

        #region TODO

        public Payment SecondClient1Payment()
        {
            return null;
        }

        public Payment ThirdClient1Payment()
        {
            return null;
        }

        #endregion

        ~FakeClients1Payments()
        {
            MyClients1Payments = null;
        }
    }
}
