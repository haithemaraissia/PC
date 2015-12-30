using System.Collections.Generic;
using DAL.Fake.Model.Util;
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
                DisputeStatusId = (int)DisputeStatus.Values.Opened,
                DisputeStatusValue = DisputeStatus.Values.Opened.ToString()
            };
            return firstDisputeStatu;
        }

        public DisputeStatu SecondDisputeStatu()
        {
            var secondDisputeStatu = new DisputeStatu
            {
                DisputeStatusId = (int)DisputeStatus.Values.Processing,
                DisputeStatusValue = DisputeStatus.Values.Processing.ToString()
            };
            return secondDisputeStatu;
        }

        public DisputeStatu ThirdDisputeStatu()
        {
            var thirdDisputeStatu = new DisputeStatu
            {
                DisputeStatusId = (int)DisputeStatus.Values.Escalated,
                DisputeStatusValue = DisputeStatus.Values.Escalated.ToString()
            };
            return thirdDisputeStatu;
        }

        public DisputeStatu FourthDisputeStatu()
        {
            var fourthDisputeStatu = new DisputeStatu
            {
                DisputeStatusId = (int)DisputeStatus.Values.Resolved,
                DisputeStatusValue = DisputeStatus.Values.Resolved.ToString()
            };
            return fourthDisputeStatu;
        }

        public DisputeStatu FifthDisputeStatu()
        {
            var fifthDisputeStatu = new DisputeStatu
            {
                DisputeStatusId = (int)DisputeStatus.Values.UnResolved,
                DisputeStatusValue = DisputeStatus.Values.UnResolved.ToString()
            };
            return fifthDisputeStatu;
        }

        ~FakeDisputeStatus()
        {
            MyDisputeStatus = null;
        }
    }
}
