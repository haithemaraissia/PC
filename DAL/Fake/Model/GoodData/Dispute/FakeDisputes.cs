using System;
using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Dispute
{
    public class FakeDisputes
    {
        public List<global::Model.Dispute> MyDisputes;

        public FakeDisputes()
        {
            InitializeDisputeList();
        }

        public void InitializeDisputeList()
        {
            MyDisputes = new List<global::Model.Dispute> {
                FirstDispute(), 
                SecondDispute(),
                ThirdDispute()
            };
        }

        public global::Model.Dispute FirstDispute()
        {
            var firstDispute = new global::Model.Dispute
            {
                DisputeId =  1,
                OrderId = 1,
                OrderModelTypeId = (int)Util.OrderModelType.Values.Transaction,
                CookerId = 1,
                ClientId = 1,
                DisputeDate = DateTime.Today.Date,
                DisputeAmount = (decimal) 8.50,
                StatusId = (int)Util.DisputeStatus.Values.Opened,
                ReasonId = (int)Util.DisputeReason.Values.ItemNotAsDescribed,
                EvidencePhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Dispute\NeverDelivered.jpg",
                Description = "This item was never delivered"
            };
            return firstDispute;
        }

        public global::Model.Dispute SecondDispute()
        {
            var secondDispute = new global::Model.Dispute();
            secondDispute.DisputeId = 2;
            secondDispute.OrderId = 2;
            secondDispute.OrderModelTypeId = (int) Util.OrderModelType.Values.Subscription;
            secondDispute.CookerId = 1;
            secondDispute.ClientId = 1;
            secondDispute.DisputeDate = DateTime.Today.Date;
            secondDispute.DisputeAmount = (decimal)6.50;
            secondDispute.StatusId = (int)Util.DisputeStatus.Values.Opened;
            secondDispute.ReasonId = (int)Util.DisputeReason.Values.OtherReasons;
            secondDispute.EvidencePhoto = "";
            secondDispute.Description = "This item was not good";
            return secondDispute;
        }

        public global::Model.Dispute ThirdDispute()
        {
            var thirdDispute = new global::Model.Dispute
            {
                DisputeId = 3,
                OrderId = 3,
                OrderModelTypeId = (int)Util.OrderModelType.Values.Transaction,
                CookerId = 1,
                ClientId = 2,
                DisputeDate = DateTime.Today.Date,
                DisputeAmount = (decimal)4.50,
                StatusId = (int)Util.DisputeStatus.Values.Processing,
                ReasonId = (int)Util.DisputeReason.Values.OtherReasons,
                EvidencePhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Dispute\BadFood.jpg",
                Description = "look at the picture and you will understand"
            };
            return thirdDispute;
        }

        ~FakeDisputes()
        {
            MyDisputes = null;
        }
    }
}
