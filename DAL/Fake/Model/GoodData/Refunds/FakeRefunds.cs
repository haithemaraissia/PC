using System;
using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Refund
{
    public class FakeRefunds
    {
        public List<global::Model.Refund> MyRefunds;

        public FakeRefunds()
        {
            InitializeRefundList();
        }

        public void InitializeRefundList()
        {
            MyRefunds = new List<global::Model.Refund> {
                FirstRefund(), 
                SecondRefund(),
                ThirdRefund()
            };
        }

        public global::Model.Refund FirstRefund()
        {
            var firstRefund = new global::Model.Refund
            {
                RefundId =  1,
                TransactionID = "GROC#43",
                OrderId = 1,
                OrderModelTypeId = (int)Util.OrderModelType.Values.Transaction,
                CookerId = 1,
                ClientId = 1,
                RefundDate = DateTime.Today.Date,
                RefundAmount = (decimal) 8.50,
                StatusId = (int)Util.DisputeStatus.Values.Resolved,
                ReasonId = (int)Util.DisputeReason.Values.ItemNotAsDescribed,
                EvidencePhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Dispute\NeverDelivered.jpg",
                Description = "This item was never delivered"
            };
            return firstRefund;
        }

        public global::Model.Refund SecondRefund()
        {
            var secondRefund = new global::Model.Refund
            {
                RefundId = 2,
                TransactionID = "LOLE9843",
                OrderId = 2,
                OrderModelTypeId = (int)Util.OrderModelType.Values.Subscription,
                CookerId = 1,
                ClientId = 1,
                RefundDate = DateTime.Today.Date,
                RefundAmount = (decimal)7.50,
                StatusId = (int)Util.DisputeStatus.Values.Processing,
                ReasonId = (int)Util.DisputeReason.Values.OtherReasons,
                EvidencePhoto = "",
                Description = "This item was not good"
            };
            return secondRefund;
        }

        public global::Model.Refund ThirdRefund()
        {
            var thirdRefund = new global::Model.Refund
            {
                RefundId = 3,
                TransactionID = "FERO#23",
                OrderId = 2,
                OrderModelTypeId = (int)Util.OrderModelType.Values.Transaction,
                CookerId = 1,
                ClientId = 2,
                RefundDate = DateTime.Today.Date,
                RefundAmount = (decimal)4.50,
                StatusId = (int)Util.DisputeStatus.Values.Escalated,
                ReasonId = (int)Util.DisputeReason.Values.OtherReasons,
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
