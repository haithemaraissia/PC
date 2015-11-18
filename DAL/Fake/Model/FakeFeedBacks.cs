using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeFeedBacks
    {
        public List<FeedBack> MyFeedBacks;

        public FakeFeedBacks()
        {
            InitializeFeedBackList();
        }

        public void InitializeFeedBackList()
        {
            MyFeedBacks = new List<FeedBack> {
                FirstFeedBack(), 
                SecondFeedBack(),
                ThirdFeedBack()
            };
        }

        public FeedBack FirstFeedBack()
        {
            var firstFeedBack = new FeedBack
            {
                FeedbackId = 1,
                OrderId = 1,
                RatingCodeId = 1,
                FeedBackDateTime = DateTime.Today.Date,
                ReviewId = 1
            };
            return firstFeedBack;
        }

        public FeedBack SecondFeedBack()
        {
            var secondFeedBack = new FeedBack
            {
                FeedbackId = 2,
                OrderId = 2,
                RatingCodeId = 3,
                FeedBackDateTime = DateTime.Today.Date,
                ReviewId = 2
            };
            return secondFeedBack;
        }

        public FeedBack ThirdFeedBack()
        {
            var thirdFeedBack = new FeedBack
            {
                FeedbackId = 3,
                OrderId = 1,
                RatingCodeId = 1,
                FeedBackDateTime = DateTime.Today.Date,
                ReviewId = 1
            };
            return thirdFeedBack;
        }

        ~FakeFeedBacks()
        {
            MyFeedBacks = null;
        }
    }
}
