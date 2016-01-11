using System.Collections.Generic;
using DAL.Fake.Model.LookUp.RatingCodes;
using Model;

namespace DAL.Fake.Model.GoodData.RatingCodes
{
    public class FakeRatingCode
    {
        public List<RatingCode> MyRatingCodes;

        public FakeRatingCode()
        {
            InitializeRatingCodeList();
        }

        public void InitializeRatingCodeList()
        {
            MyRatingCodes = new List<RatingCode> {
                FirstRatingCode(), 
                SecondRatingCode(),
                ThirdRatingCode()
            };
        }

        public RatingCode FirstRatingCode()
        {
            var firstRatingCode = new RatingCode
            {
                RatingCodeId = (int)RatingCodeType.Values.Positive,
                RatingCodeValue = RatingCodeType.Values.Positive.ToString()
            };
            return firstRatingCode;
        }

        public RatingCode SecondRatingCode()
        {
            var secondRatingCode = new RatingCode
            {
                RatingCodeId = (int)RatingCodeType.Values.Negative,
                RatingCodeValue = RatingCodeType.Values.Negative.ToString()
            };
            return secondRatingCode;
        }

        public RatingCode ThirdRatingCode()
        {
            var thirdRatingCode = new RatingCode
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

