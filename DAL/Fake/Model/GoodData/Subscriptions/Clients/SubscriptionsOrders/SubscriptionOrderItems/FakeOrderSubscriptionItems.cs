using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Cookers.Dishes.Cooker;
using DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders.SubscriptionOrderItems.SubscriptionOrderItemDishOptions;
using DAL.Fake.Model.LookUp.OrderStatu;
using DAL.Fake.Model.Util.Subscriptions;
using Model;

namespace DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders.SubscriptionOrderItems
{
    public class FakeOrderSubscriptionItems
    {
        private readonly List<OrderSubscription> _myOrders;
        public List<OrderSubscriptionItem> MySubscriptionsOrderItems;

        public FakeOrderSubscriptionItems()
        {
            _myOrders = new FakeSubscriptionsOrder().MyOrderSubscriptions;
            InitializeOrderSubscriptionItemsList();
        }

        private void InitializeOrderSubscriptionItemsList()
        {
            MySubscriptionsOrderItems = new List<OrderSubscriptionItem> {
                GetFirstOrderSubscriptionItem(),
                GetSecondOrderSubscriptionItem(),
                GetThirdOrderSubscriptionItem(),
                GetFourthOrderSubscriptionItem()
            };
        }


        public OrderSubscriptionItem GetFirstOrderSubscriptionItem()
        {
            var selectedDish = new FakeCooker1Dishes().MostPopularDish1();
            var firstSubscriptionOrderItemDetail = new OrderSubscriptionItem
            {
                OrderSubscriptionItemId = 1,
                DishId = selectedDish.DishId,
                CookerId = selectedDish.CookerId,
                MenuId = selectedDish.MenuId,
                Quantity = 1,
                Description = selectedDish.Description,
                Instructions = "Put Extra French Fries",
                OrderSubscriptionId = 1,
                ClientOrderReviewSentClientOrderReviewSentId = new SubscriptionHelper().CreateOrderReview(selectedDish, _myOrders.Max(x => x.OrderSubscriptionId) + 1).ClientOrderToReviewId,
                WeekId = 1,
                ScheduledDate = DateTime.Today.Date,
                OrderStatusId = (int)OrderStatus.Values.Scheduled
            };



            firstSubscriptionOrderItemDetail.OrderSubscriptionItemDishOptions.Add(new FakeSubscriptionOrderItemDishOptions().FirstSubscriptionOrderItemDishOption());
            firstSubscriptionOrderItemDetail.OrderSubscriptionItemDishOptions.Add(new FakeSubscriptionOrderItemDishOptions().SecondSubscriptionOrderItemDishOption());
            return firstSubscriptionOrderItemDetail;
        }

        public OrderSubscriptionItem GetSecondOrderSubscriptionItem()
        {
            var selectedDish = new FakeCooker1Dishes().MostPopularDish2();
            var secondSubscriptionOrderItemDetail = new OrderSubscriptionItem
            {
                OrderSubscriptionItemId = 2,
                DishId = selectedDish.DishId,
                CookerId = selectedDish.CookerId,
                MenuId = selectedDish.MenuId,
                Quantity = 1,
                Description = selectedDish.Description,
                Instructions = "Put Extra Spices",
                OrderSubscriptionId = 1,
                ClientOrderReviewSentClientOrderReviewSentId = new SubscriptionHelper().CreateOrderReview(selectedDish, _myOrders.Max(x => x.OrderSubscriptionId) + 1).ClientOrderToReviewId,
                WeekId = 2,
                ScheduledDate = DateTime.Today.Date.AddDays(2),
                OrderStatusId = (int)OrderStatus.Values.Scheduled
            };
            secondSubscriptionOrderItemDetail.OrderSubscriptionItemDishOptions.Add(new FakeSubscriptionOrderItemDishOptions().ThirdSubscriptionOrderItemDishOption());
            return secondSubscriptionOrderItemDetail;
        }

        public OrderSubscriptionItem GetThirdOrderSubscriptionItem()
        {
            var selectedDish = new FakeCooker1Dishes().SoupAndSaladDish1();
            var thirdSubscriptionOrderItemDetail = new OrderSubscriptionItem
            {
                OrderSubscriptionItemId = 3,
                DishId = selectedDish.DishId,
                CookerId = selectedDish.CookerId,
                MenuId = selectedDish.MenuId,
                Quantity = 1,
                Description = selectedDish.Description,
                Instructions = null,
                OrderSubscriptionId = 1,
                ClientOrderReviewSentClientOrderReviewSentId = new SubscriptionHelper().CreateOrderReview(selectedDish, _myOrders.Max(x => x.OrderSubscriptionId) + 1).ClientOrderToReviewId,
                WeekId = 3,
                ScheduledDate = DateTime.Today.Date.AddDays(4),
                OrderStatusId = (int)OrderStatus.Values.Scheduled
            };
            return thirdSubscriptionOrderItemDetail;
        }

        public OrderSubscriptionItem GetFourthOrderSubscriptionItem()
        {
            var selectedDish = new FakeCooker1Dishes().SoupAndSaladDish1();
            var fourthSubscriptionOrderItemDetail = new OrderSubscriptionItem
            {
                OrderSubscriptionItemId = 4,
                DishId = selectedDish.DishId,
                CookerId = selectedDish.CookerId,
                MenuId = selectedDish.MenuId,
                Quantity = 1,
                Description = selectedDish.Description,
                Instructions = null,
                OrderSubscriptionId = 1,
                ClientOrderReviewSentClientOrderReviewSentId = new SubscriptionHelper().CreateOrderReview(selectedDish, _myOrders.Max(x => x.OrderSubscriptionId) + 1).ClientOrderToReviewId,
                WeekId = 4,
                ScheduledDate = DateTime.Today.Date.AddDays(1),
                OrderStatusId = (int)OrderStatus.Values.Scheduled
            };
            return fourthSubscriptionOrderItemDetail;
        }


    }
}
