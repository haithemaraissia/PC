using System.Collections.Generic;
using DAL.Fake.Model.Util;

namespace DAL.Fake.Model.GoodData.Review
{
    public class FakeReviews
    {
        public List<global::Model.Review> MyReviews;

        public FakeReviews()
        {
            InitializeReviewList();
        }

        public void InitializeReviewList()
        {
            MyReviews = new List<global::Model.Review> {
                FirstReview(), 
                SecondReview(),
                ThirdReview()
            };
        }

        public global::Model.Review FirstReview()
        {
            var firstReview = new global::Model.Review
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

        public global::Model.Review SecondReview()
        {
            var secondReview = new global::Model.Review
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

        public global::Model.Review ThirdReview()
        {
            var thirdReview = new global::Model.Review
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
