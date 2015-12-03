using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cookers
{
    public class FakeCookerReviewScore
    {
        public List<CookerReviewScore> MyCookerReviewScore;

        public FakeCookerReviewScore()
        {
            InitializeCookerList();
        }

        public void InitializeCookerList()
        {
            MyCookerReviewScore = new List<CookerReviewScore> {
                FirstCookerReviewScore()
            };
        }

        private CookerReviewScore FirstCookerReviewScore()
        {
            var firstCookerReviewScore = new CookerReviewScore
            {
                CookerReviewScoreId = 1,
                CookerId = 1,
                PositiveReview = 1,
                NegativeReview = 0,
                NeutralReview = 0,
                OrderDate = DateTime.Today.Date
            };
            return firstCookerReviewScore;
        }

        ~FakeCookerReviewScore()
        {
            MyCookerReviewScore = null;
        }
    }
}
