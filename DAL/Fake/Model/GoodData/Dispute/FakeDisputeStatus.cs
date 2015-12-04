using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Dispute
{
    public class FakeDisputeStatus
    {
        public List<DisputeStatu> MyDisputeStatus;

        public FakeDisputeStatus()
        {
            InitializeDisputeStatuList();
        }

        public void InitializeDisputeStatuList()
        {
            MyDisputeStatus = new List<DisputeStatu> {
                FirstDisputeStatu(), 
                SecondDisputeStatu(),
                ThirdDisputeStatu(),
                FourthDisputeStatu(),
                FifthDisputeStatu()
            };
        }

        public DisputeStatu FirstDisputeStatu()
        {
            var firstDisputeStatu = new DisputeStatu
            {
                DisputeStatusId = 1,
                DisputeStatusValue = "Opened"
            };
            return firstDisputeStatu;
        }

        public DisputeStatu SecondDisputeStatu()
        {
            var secondDisputeStatu = new DisputeStatu
            {
                DisputeStatusId = 2,
                DisputeStatusValue = "Processing"
            };
            return secondDisputeStatu;
        }

        public DisputeStatu ThirdDisputeStatu()
        {
            var thirdDisputeStatu = new DisputeStatu
            {
                DisputeStatusId = 3,
                DisputeStatusValue = "Escalated"
            };
            return thirdDisputeStatu;
        }

        public DisputeStatu FourthDisputeStatu()
        {
            var fourthDisputeStatu = new DisputeStatu
            {
                DisputeStatusId = 4,
                DisputeStatusValue = "Resolved"
            };
            return fourthDisputeStatu;
        }

        public DisputeStatu FifthDisputeStatu()
        {
            var fifthDisputeStatu = new DisputeStatu
            {
                DisputeStatusId = 5,
                DisputeStatusValue = "UnResolved"
            };
            return fifthDisputeStatu;
        }

        ~FakeDisputeStatus()
        {
            MyDisputeStatus = null;
        }
    }
}
