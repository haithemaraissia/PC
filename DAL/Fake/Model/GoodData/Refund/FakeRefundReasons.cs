using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Refund
{
    public class FakeRefundReason
    {
        public List<RefundReason> MyRefundReasons;

        public FakeRefundReason()
        {
            InitializeRefundReasonList();
        }

        public void InitializeRefundReasonList()
        {
            MyRefundReasons = new List<RefundReason> {
                FirstRefundReason(), 
                SecondRefundReason()
            };
        }

        public RefundReason FirstRefundReason()
        {
            var firstRefundReason = new RefundReason
            {
                RefundReasonId = 1,
                RefundReasonValue = "Item not as described"
            };
            return firstRefundReason;
        }

        public RefundReason SecondRefundReason()
        {
            var secondRefundReason = new RefundReason
            {
                RefundReasonId = 2,
                RefundReasonValue = "Other reasons"
            };
            return secondRefundReason;
        }


        ~FakeRefundReason()
        {
            MyRefundReasons = null;
        }
    }
}
