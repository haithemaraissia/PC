using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
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
                RatingCodeId = 1,
                RatingCodeValue = "Positive"
            };
            return firstRatingCode;
        }

        public RatingCode SecondRatingCode()
        {
            var secondRatingCode = new RatingCode
            {
                RatingCodeId = 2,
                RatingCodeValue = "Negative"
            };
            return secondRatingCode;
        }

        public RatingCode ThirdRatingCode()
        {
            var thirdRatingCode = new RatingCode
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
