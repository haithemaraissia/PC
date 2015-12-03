using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Orders.Clients;
using Model;

namespace DAL.Fake.Model.GoodData.Reviews.Clients
{
    public class FakeClientOrdersReviewReceived
    {
        public List<ClientOrderReviewReceived> MyClientOrdersReviewReceived;

        public FakeClientOrdersReviewReceived()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyClientOrdersReviewReceived = new List<ClientOrderReviewReceived> {
                FirstClientOrderReviewReceived()
            };
        }

        public ClientOrderReviewReceived FirstClientOrderReviewReceived()
        {
            var firstClientOrderReviewReceived = new ClientOrderReviewReceived
            {
                ClientOrderReviewReceivedId =  1,
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
                //View Model OrderItems =  (from c in new FakeOrderItems().MyOrderItems where c.OrderId == 1 select c).ToList()
            };
            return firstClientOrderReviewReceived;
        }


        ~FakeClientOrdersReviewReceived()
        {
            MyClientOrdersReviewReceived = null;
        }
    }
}
