using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Refund
{
    public class FakeRefundStatus
    {
        public List<RefundStatu> MyRefundStatus;

        public FakeRefundStatus()
        {
            InitializeRefundStatuList();
        }

        public void InitializeRefundStatuList()
        {
            MyRefundStatus = new List<RefundStatu> {
                FirstRefundStatu(), 
                SecondRefundStatu(),
                ThirdRefundStatu(),
                FourthRefundStatu(),
                FifthRefundStatu()
            };
        }

        public RefundStatu FirstRefundStatu()
        {
            var firstRefundStatu = new RefundStatu
            {
                RefundStatusId = 1,
                RefundStatusValue = "Opened"
            };
            return firstRefundStatu;
        }

        public RefundStatu SecondRefundStatu()
        {
            var secondRefundStatu = new RefundStatu
            {
                RefundStatusId = 2,
                RefundStatusValue = "Processing"
            };
            return secondRefundStatu;
        }

        public RefundStatu ThirdRefundStatu()
        {
            var thirdRefundStatu = new RefundStatu
            {
                RefundStatusId = 3,
                RefundStatusValue = "Escalated"
            };
            return thirdRefundStatu;
        }

        public RefundStatu FourthRefundStatu()
        {
            var fourthRefundStatu = new RefundStatu
            {
                RefundStatusId = 4,
                RefundStatusValue = "Resolved"
            };
            return fourthRefundStatu;
        }

        public RefundStatu FifthRefundStatu()
        {
            var fifthRefundStatu = new RefundStatu
            {
                RefundStatusId = 5,
                RefundStatusValue = "UnResolved"
            };
            return fifthRefundStatu;
        }

        ~FakeRefundStatus()
        {
            MyRefundStatus = null;
        }
    }
}
