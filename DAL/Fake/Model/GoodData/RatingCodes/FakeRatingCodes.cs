using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.RatingCode
{
    public class FakeRatingCode
    {
        public List<global::Model.RatingCode> MyRatingCodes;

        public FakeRatingCode()
        {
            InitializeRatingCodeList();
        }

        public void InitializeRatingCodeList()
        {
            MyRatingCodes = new List<global::Model.RatingCode> {
                FirstRatingCode(), 
                SecondRatingCode(),
                ThirdRatingCode()
            };
        }

        public global::Model.RatingCode FirstRatingCode()
        {
            var firstRatingCode = new global::Model.RatingCode
            {
                RatingCodeId = 1,
                RatingCodeValue = "Positive"
            };
            return firstRatingCode;
        }

        public global::Model.RatingCode SecondRatingCode()
        {
            var secondRatingCode = new global::Model.RatingCode
            {
                RatingCodeId = 2,
                RatingCodeValue = "Negative"
            };
            return secondRatingCode;
        }

        public global::Model.RatingCode ThirdRatingCode()
        {
            var thirdRatingCode = new global::Model.RatingCode
            {
                RatingCodeId = 3,
                RatingCodeValue = "Neutral"
            };
            return thirdRatingCode;
        }

        ~FakeRatingCode()
        {
            MyRatingCodes = null;
        }
    }
}

