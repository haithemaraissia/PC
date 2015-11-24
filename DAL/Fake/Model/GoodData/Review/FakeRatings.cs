using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Review
{
    public class FakeRatings
    {
        public List<Rating> MyRatings;

        public FakeRatings()
        {
            InitializeRatingList();
        }

        public void InitializeRatingList()
        {
            MyRatings = new List<Rating> {
                FirstRating(), 
                SecondRating(),
                ThirdRating()
            };
        }

        public Rating FirstRating()
        {
            var firstRating = new Rating
            {
                RatingId = 1,
                ItemAccuracy = 5,
                Communication = 5,
                DeliveryTime = 4,
                Overall = 4,
            };
            return firstRating;
        }

        public Rating SecondRating()
        {
            var secondRating = new Rating
            {
                RatingId = 2,
                ItemAccuracy = 2,
                Communication = 3,
                DeliveryTime = 3,
                Overall = 4,
            };
            return secondRating;
        }

        public Rating ThirdRating()
        {
            var thirdRating = new Rating
            {
                RatingId = 3,
                ItemAccuracy = 4,
                Communication = 1,
                DeliveryTime = 2,
                Overall = 1,
            };
            return thirdRating;
        }

        ~FakeRatings()
        {
            MyRatings = null;
        }
    }
}
