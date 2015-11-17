using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model
{
    public class FakeReviews
    {
        public List<Review> MyReviews;

        public FakeReviews()
        {
            InitializeReviewList();
        }

        public void InitializeReviewList()
        {
            MyReviews = new List<Review> {
                FirstReview(), 
                SecondReview(),
                ThirdReview()
            };
        }

        public Review FirstReview()
        {
            var firstReview = new Review
            {
                ReviewId = 1,
                CookerId = 1,
                MenuId = 1,
                Comment = "This is a comment from Client to Cooker",
                OrderId = 1,
                ClientId = 1,
                UserTypeId = (int)UserTypes.Values.Client,
                Photo = null,
                RatingId = 1
            };
            return firstReview;
        }

        public Review SecondReview()
        {
            var secondReview = new Review
            {
                ReviewId = 2,
                CookerId = 2,
                MenuId = 1,
                Comment = "This is a comment from Cooker to Client",
                OrderId = 1,
                ClientId = 1,
                UserTypeId = (int)UserTypes.Values.Cooker,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Review\bad_food_med.jpeg",
                RatingId = 2
            };
            return secondReview;
        }

        public Review ThirdReview()
        {
            var thirdReview = new Review
            {
                ReviewId = 3,
                CookerId = 1,
                MenuId = 1,
                Comment = "This is comment from Client to Cooker",
                OrderId = 1,
                ClientId = 3,
                UserTypeId = (int)UserTypes.Values.Client,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Review\badfood.jpg",
                RatingId = 3
            };
            return thirdReview;
        }

        ~FakeReviews()
        {
            MyReviews = null;
        }
    }
}
