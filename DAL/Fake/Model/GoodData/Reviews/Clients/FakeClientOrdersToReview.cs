using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Orders.Clients;
using Model;

namespace DAL.Fake.Model.GoodData.Reviews.Clients
{
    public class FakeClientOrderToReview
    {
        public List<ClientOrderToReview> MyClientOrderToReview;

        public FakeClientOrderToReview()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyClientOrderToReview = new List<ClientOrderToReview> {
                FirstClientOrderToReview()
            };
        }


        #region Client1

        public ClientOrderToReview FirstClientOrderToReview()
        {
            var firstClientOrderToReview = new ClientOrderToReview
            {
                ClientOrderToReviewId = 1,
                ClientId = 1,
                CookerId = 1,
                MenuId = 1,
                OrderId = 1,
                OverallFeedBackRating = 0,
                ItemAccuracyRating = 0,
                CommunicationRating = 0,
                DeliveryTimeRating = 0,
                Comment = null,
                Photo = null,
                OrderDate = DateTime.Today.Date,
             //View Model   OrderItems = (from c in new FakeOrderItems().MyOrderItems where c.OrderId == 1 select c).ToList()
            };
            return firstClientOrderToReview;
        }

        #endregion

        ~FakeClientOrderToReview()
        {
            MyClientOrderToReview = null;
        }
    }
}
