using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Reviews.Cookers
{
    public class FakeCookerFeedbacks
    {
        public List<CookerFeedBack> MyCookersFakeCookerFeedbacks;

        public FakeCookerFeedbacks()
        {
            InitializeCookerList();
        }

        public void InitializeCookerList()
        {
            MyCookersFakeCookerFeedbacks = new List<CookerFeedBack> {
                FirstCookerFeedback(), 
            };
        }

        public CookerFeedBack FirstCookerFeedback()
        {
            var firstCookerFeedback = new CookerFeedBack
            {
                CookerFeedBackId = 1,
                CookerId = 1,
                CookerRestaurantName = "Bob's Restaurant",
                TransactionsCount = 2,
                ReviewScore = 5,
                PositiveReview = (decimal) 0.5
            };
            return firstCookerFeedback;
        }


        ~FakeCookerFeedbacks()
        {
            MyCookersFakeCookerFeedbacks = null;
        }
    }
}
