using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Reviews.Industry
{
    public class FakeIndustryAverageRatings
    {
        public List<IndustryAverageRating> MyIndustryAverageRatings;

        public FakeIndustryAverageRatings()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyIndustryAverageRatings = new List<IndustryAverageRating> {
                FirstIndustryAverageRating()
            };
        }

        public IndustryAverageRating FirstIndustryAverageRating()
        {
            var firstIndustryAverageRating  = new IndustryAverageRating
            {
            IndustryAverageRatingId = 1,
            ItemAccuracyIndustryAverageRating = (decimal) 4.8,
            CommunicationIndustryAverageRating  = (decimal) 4.7,
            DeliveryTimeIndustryAverageRating  = (decimal) 4.9,
            OverallFeedBackIndustryAverageRating  = (decimal) 5.0,
            };
            return firstIndustryAverageRating;
        }

        ~FakeIndustryAverageRatings()
        {
            MyIndustryAverageRatings = null;
        }
    }
}
