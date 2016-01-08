using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Dispute
{
    public class FakeDisputeReason
    {
        public List<DisputeReason> MyDisputeReasons;

        public FakeDisputeReason()
        {
            InitializeDisputeReasonList();
        }

        public void InitializeDisputeReasonList()
        {
            MyDisputeReasons = new List<DisputeReason> {
                FirstDisputeReason(), 
                SecondDisputeReason()
            };
        }

        public DisputeReason FirstDisputeReason()
        {
            var firstDisputeReason = new DisputeReason
            {
                DisputeReasonId = (int)LookUp.Dispute.DisputeReason.Values.ItemNotAsDescribed,
                DisputeReasonValue =  LookUp.Dispute.DisputeReason.Values.ItemNotAsDescribed.ToString()
            };
            return firstDisputeReason;
        }

        public DisputeReason SecondDisputeReason()
        {
            var secondDisputeReason = new DisputeReason
            {
                DisputeReasonId = (int)LookUp.Dispute.DisputeReason.Values.OtherReasons,
                DisputeReasonValue = LookUp.Dispute.DisputeReason.Values.OtherReasons.ToString()
            };
            return secondDisputeReason;
        }


        ~FakeDisputeReason()
        {
            MyDisputeReasons = null;
        }
    }
}
