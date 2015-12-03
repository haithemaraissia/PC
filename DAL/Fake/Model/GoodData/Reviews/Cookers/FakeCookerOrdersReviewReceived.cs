using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Orders.Clients;
using Model;

namespace DAL.Fake.Model.GoodData.Reviews.Cookers
{
    public class FakeCookerOrdersReviewReceived
    {
        public List<CookerOrderReviewReceived> MyCookerOrdersReviewReceived;

        public FakeCookerOrdersReviewReceived()
        {
            InitializeCookerList();
        }

        public void InitializeCookerList()
        {
            MyCookerOrdersReviewReceived = new List<CookerOrderReviewReceived> {
                FirstCookerOrderReviewReceived()
            };
        }

        public CookerOrderReviewReceived FirstCookerOrderReviewReceived()
        {
            var firstCookerOrderReviewReceived = new CookerOrderReviewReceived
            {
                CookerOrderReviewReceivedId =  1,
                CookerId = 1,
                ClientId = 1,
                MenuId = 1,
                OrderId = 1,
                OverallFeedBackRating = 0,
                ItemAccuracyRating = 0,
                CommunicationRating = 0,
                DeliveryTimeRating = 0,
                Comment = null,
                Photo = null,
                OrderDate = DateTime.Today.Date,
              //ViewModel  OrderItems =  (from c in new FakeOrderItems().MyOrderItems where c.OrderId == 1 select c).ToList()
            };
            return firstCookerOrderReviewReceived;
        }


        ~FakeCookerOrdersReviewReceived()
        {
            MyCookerOrdersReviewReceived = null;
        }
    }
}
