using System;
using System.Collections.Generic;
using DAL.Fake.Model.LookUp.Dispute;
using Model;
using DisputeReason = DAL.Fake.Model.LookUp.Dispute.DisputeReason;

namespace DAL.Fake.Model.GoodData.Refunds
{
    public class FakeRefunds
    {
        public List<Refund> MyRefunds;

        public FakeRefunds()
        {
            InitializeRefundList();
        }

        public void InitializeRefundList()
        {
            MyRefunds = new List<Refund> {
                FirstRefund(), 
                SecondRefund(),
                ThirdRefund()
            };
        }

        public Refund FirstRefund()
        {
            var firstRefund = new Refund
            {
                RefundId =  1,
                TransactionID = "GROC#43",
                OrderId = 1,
                OrderModelTypeId = (int)LookUp.OrderModel.OrderModelType.Values.Transaction,
                CookerId = 1,
                ClientId = 1,
                RefundDate = DateTime.Today.Date,
                RefundAmount = (decimal) 8.50,
                StatusId = (int)DisputeStatus.Values.Resolved,
                ReasonId = (int)DisputeReason.Values.ItemNotAsDescribed,
                EvidencePhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Dispute\NeverDelivered.jpg",
                Description = "This item was never delivered"
            };
            return firstRefund;
        }

        public Refund SecondRefund()
        {
            var secondRefund = new Refund
            {
                RefundId = 2,
                TransactionID = "LOLE9843",
                OrderId = 2,
                OrderModelTypeId = (int)LookUp.OrderModel.OrderModelType.Values.Subscription,
                CookerId = 1,
                ClientId = 1,
                RefundDate = DateTime.Today.Date,
                RefundAmount = (decimal)7.50,
                StatusId = (int)DisputeStatus.Values.Processing,
                ReasonId = (int)DisputeReason.Values.OtherReasons,
                EvidencePhoto = "",
                Description = "This item was not good"
            };
            return secondRefund;
        }

        public Refund ThirdRefund()
        {
            var thirdRefund = new Refund
            {
                RefundId = 3,
                TransactionID = "FERO#23",
                OrderId = 2,
                OrderModelTypeId = (int)LookUp.OrderModel.OrderModelType.Values.Transaction,
                CookerId = 1,
                ClientId = 2,
                RefundDate = DateTime.Today.Date,
                RefundAmount = (decimal)4.50,
                StatusId = (int)DisputeStatus.Values.Escalated,
                ReasonId = (int)DisputeReason.Values.OtherReasons,
                EvidencePhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Refund\BadFood.jpg",
                Description = "look at the picture and you will understand"
            };
            return thirdRefund;
        }

        ~FakeRefunds()
        {
            MyRefunds = null;
        }
    }
}
