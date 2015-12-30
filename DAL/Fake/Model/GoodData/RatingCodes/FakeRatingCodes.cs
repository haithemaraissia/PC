using System.Collections.Generic;
using DAL.Fake.Model.Util;

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
                RatingCodeId = (int)RatingCodeType.Values.Positive,
                RatingCodeValue = RatingCodeType.Values.Positive.ToString()
            };
            return firstRatingCode;
        }

        public global::Model.RatingCode SecondRatingCode()
        {
            var secondRatingCode = new global::Model.RatingCode
            {
                RatingCodeId = (int)RatingCodeType.Values.Negative,
                RatingCodeValue = RatingCodeType.Values.Negative.ToString()
            };
            return secondRatingCode;
        }

        public global::Model.RatingCode ThirdRatingCode()
        {
            var thirdRatingCode = new global::Model.RatingCode
            {
                RatingCodeId = (int)RatingCodeType.Values.Neutral,
                RatingCodeValue = RatingCodeType.Values.Neutral.ToString()
            };
            return thirdRatingCode;
        }

        ~FakeRatingCode()
        {
            MyRatingCodes = null;
        }
    }
}

