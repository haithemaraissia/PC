using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Payments.Clients.Client1;
using DAL.Fake.Model.LookUp.PaymentStatus;
using Model;

namespace DAL.Fake.Model.GoodData.PaymentsHistory.Client1
{
    public class FakeClients1PaymentsHistory
    {
        public List<global::Model.PaymentsHistory> MyClients1PaymentsHistory;

        public FakeClients1PaymentsHistory()
        {
            InitializeClients1PaymentsHistoryList();
        }

        public void InitializeClients1PaymentsHistoryList()
        {
            MyClients1PaymentsHistory = new List<global::Model.PaymentsHistory> {
                FirstClient1PaymentHistory(), 
                SecondClient1PaymentHistory(),
                ThirdClient1PaymentHistory()
            };
        }

        public global::Model.PaymentsHistory FirstClient1PaymentHistory()
        {
            Payment FirstPayment =  new FakeClients1Payments().MyClients1Payments.First();
            if (FirstPayment != null)
            {
                var Payment = new global::Model.PaymentsHistory
                {
                    PaymentHistoryId = 1,
                    InvoiceId = FirstPayment.InvoiceId,
                    PaymentDate = DateTime.Now.Date,
                    PaymentAmount = FirstPayment.PaymentAmount,
                    OrderId = (int)FirstPayment.OrderId,
                    ClientId = FirstPayment.ClientId,
                    CookerId = FirstPayment.CookerId,
                    TransactionId = "G126F85",
                    OrderModelTypeId = (int)LookUp.OrderModel.OrderModelType.Values.Transaction,
                    PaymentStatusId = (int)PaymentStatusType.Values.Completed
                    
                };


                return Payment;
            }
            return null;
        }

        #region TODO

        public global::Model.PaymentsHistory SecondClient1PaymentHistory()
        {
            return null;
        }

        public global::Model.PaymentsHistory ThirdClient1PaymentHistory()
        {
            return null;
        }

        #endregion

        ~FakeClients1PaymentsHistory()
        {
            MyClients1PaymentsHistory = null;
        }
    }
}
