using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Refund
{
    public class FakeRefundType
    {

        public List<RefundType> MyRefundTypes;

        public FakeRefundType()
        {
            InitializeRefundTypeList();
        }

        public void InitializeRefundTypeList()
        {
            MyRefundTypes = new List<RefundType> {
                FirstRefundType(), 
                SecondRefundType()
            };
        }

        public RefundType FirstRefundType()
        {
            var firstRefundType = new RefundType
            {
                RefundTyped = 1,
                RefundTypedValue = "Transaction"
            };
            return firstRefundType;
        }

        public RefundType SecondRefundType()
        {
            var secondRefundType = new RefundType
            {
                RefundTyped = 1,
                RefundTypedValue = "Subscription"
            };
            return secondRefundType;
        }


        ~FakeRefundType()
        {
            MyRefundTypes = null;
        }
    }
}
