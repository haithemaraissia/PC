using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Orders.Clients;
using Model;

namespace DAL.Fake.Model.GoodData.Reviews.Clients
{
    public class FakeClientOrdersReviewSent
    {
        public List<ClientOrderReviewSent> MyClientOrdersReviewSent;

        public FakeClientOrdersReviewSent()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyClientOrdersReviewSent = new List<ClientOrderReviewSent> {
                FirstClientOrderReviewSent()
            };
        }

        public ClientOrderReviewSent FirstClientOrderReviewSent()
        {
            var firstClientOrderReviewSent = new ClientOrderReviewSent
            {
                ClientOrderReviewSentId =  1,
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
                //OrderItems =  (from c in new FakeOrderItems().MyOrderItems where c.OrderId == 1 select c).ToList()
            };
            return firstClientOrderReviewSent;
        }


        ~FakeClientOrdersReviewSent()
        {
            MyClientOrdersReviewSent = null;
        }
    }
}
