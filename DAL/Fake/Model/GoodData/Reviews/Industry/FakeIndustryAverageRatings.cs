using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Clients
{
    public class FakeIndustryAverageRatings
    {
        public List<IndustryAverageRating> MyClients;

        public FakeIndustryAverageRatings()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyClients = new List<IndustryAverageRating> {
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
            MyClients = null;
        }
    }
}
