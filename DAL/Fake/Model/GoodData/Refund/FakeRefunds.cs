using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
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
                OrderDetailId = 5,
                RefundTypeId = 1,
                DisputeDate = DateTime.Today.Date,
                RefundAmount = (decimal) 8.50,
                StatusId = 1,
                ReasonId = 1,
                Evidence = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Refund\NeverDelivered.jpg",
                Description = "This item was never delivered"
            };
            return firstRefund;
        }

        public Refund SecondRefund()
        {
            var secondRefund = new Refund
            {
                RefundId = 2,
                OrderDetailId = 2,
                RefundTypeId = 2,
                DisputeDate = DateTime.Today.Date,
                RefundAmount = (decimal)7.50,
                StatusId = 1,
                ReasonId = 2,
                Evidence = "",
                Description = "This item was not good"
            };
            return secondRefund;
        }

        public Refund ThirdRefund()
        {
            var thirdRefund = new Refund
            {
                RefundId = 1,
                OrderDetailId = 5,
                RefundTypeId = 1,
                DisputeDate = DateTime.Today.Date,
                RefundAmount = (decimal)4.50,
                StatusId = 1,
                ReasonId = 1,
                Evidence = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Refund\BadFood.jpg",
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
