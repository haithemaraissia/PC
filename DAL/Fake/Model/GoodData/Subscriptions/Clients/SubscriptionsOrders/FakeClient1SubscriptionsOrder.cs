using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker;
using DAL.Fake.Model.Util;
using DAL.Fake.Model.Util.Subscriptions;
using Model;
using OrderType = DAL.Fake.Model.Util.OrderType;

namespace DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders
{
    public class FakeClient1SubscriptionsOrder
    {
        public List<OrderSubscription> MyOrders;

        private const int ClientSubscriptionId = 1;

        public FakeClient1SubscriptionsOrder()
        {
            InitializeOrderList();
        }

        private void InitializeOrderList()
        {
            MyOrders = new List<OrderSubscription> {
                FirstSubscriptionOrder()
            };

        }

        #region From Plan1 subscription

        #region 12 Orders Chosen by Client when buying subscription
        
        //Plan
        //PlanId = 1,
        //ExternalId = "1",
        //Description = "3 Meals per week",
        //Title="Mike Weekly Plan"

        // Cooker Subscription
        // CookerSubscriptionId = 1,
        // CookerId = 1,
        // PlanId = 1,
        // ServingPriceId = 1

        //SubscriptionServingPrice

        // ServingPrice
        // {
        //     ServicePriceId = 1,
        //     ServingMeasurementId = 1,
        //     PLanId = 1,
        //     Price = (decimal)19.99,
        //     Quantity = 1
        // }


        public OrderSubscription FirstSubscriptionOrder()
        {

            var cookerServingPriceModel = new SubscriptionHelper().GetCookerServingPriceModel(ClientSubscriptionId);

            var firstSubscriptionOrder = new OrderSubscription
            {
                OrderSubscriptionId = 1,
                ClientId = 1,
                OrderDate = DateTime.Today.Date,
                DeliveryDate = null,
                OrderTypeId = (int)OrderType.Values.PickUp,
                PaymentMethodId = (int)PaymentMethodType.Values.CardOnLine,
                CouponId = null,
                PromotionId = null,
                PlanId = cookerServingPriceModel.PLanId,
                SubTotal = cookerServingPriceModel.Price,
                CurrencyId = (int)CurrencyType.Values.Usd,
                OrderStatusId = (int)OrderStatus.Values.InProgress,
                ServingMeasurementId = cookerServingPriceModel.ServingMeasurementId,
                NumberofServingTotal = 4 * cookerServingPriceModel.Quantity,
                ClientSubscriptionId = ClientSubscriptionId,
            };

            #region Week1
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetFirstOrderSubscriptionItem((int)WeekType.Values.Week1));
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetSecondOrderSubscriptionItem((int)WeekType.Values.Week1));
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetThirdOrderSubscriptionItem((int)WeekType.Values.Week1));
            #endregion

            #region Week2
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetFirstOrderSubscriptionItem((int)WeekType.Values.Week2));
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetSecondOrderSubscriptionItem((int)WeekType.Values.Week2));
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetFourthOrderSubscriptionItem((int)WeekType.Values.Week2));
            #endregion

            #region Week3
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetFirstOrderSubscriptionItem((int)WeekType.Values.Week3));
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetSecondOrderSubscriptionItem((int)WeekType.Values.Week3));
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetThirdOrderSubscriptionItem((int)WeekType.Values.Week3));
            #endregion

            #region Week4
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetFirstOrderSubscriptionItem((int)WeekType.Values.Week4));
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetFourthOrderSubscriptionItem((int)WeekType.Values.Week4));
            firstSubscriptionOrder.OrderSubscriptionItems.Add(GetFirstOrderSubscriptionItem((int)WeekType.Values.Week4));
            #endregion

            return firstSubscriptionOrder;


        }

        #region OrderSubscriptionItems

        private OrderSubscriptionItem GetFirstOrderSubscriptionItem(int weekId)
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
                OrderSubscriptionId = MyOrders.Max(x => x.OrderSubscriptionId) + 1,
                ClientOrderReviewSentClientOrderReviewSentId = new SubscriptionHelper().CreateOrderReview(selectedDish, MyOrders.Max(x => x.OrderSubscriptionId) + 1).ClientOrderToReviewId,
                WeekId = weekId,
                ScheduledDate = DateTime.Today.Date
            };

            //Required Side
            var firstOrderDetailOption = new OrderSubscriptionItemDishOption
            {
                OrderSubscriptionItemDishOptionId = 1,
                DishOptionChoiceId = 3,
                DishOptionChoiceValue = "Cucumber Salad",
                DishOptionId = (int)DishOptionType.Values.FakeRequiredSideTwelveOptionChoices,
                Instructions = "no Mayone Please",
                OrderSubscriptionItemId = 1
            };

            //Optional Side
            var secondOrderDetailOption = new OrderSubscriptionItemDishOption
            {
                OrderSubscriptionItemDishOptionId = 2,
                DishOptionChoiceId = 17,
                DishOptionChoiceValue = "House Salad",
                DishOptionId = (int)DishOptionType.Values.FakeOptionalSideThreeOptionChoices,
                Instructions = "More Lettuce",
                OrderSubscriptionItemId = 1
            };

            firstSubscriptionOrderItemDetail.OrderSubscriptionItemDishOptions.Add(firstOrderDetailOption);
            firstSubscriptionOrderItemDetail.OrderSubscriptionItemDishOptions.Add(secondOrderDetailOption);
            return firstSubscriptionOrderItemDetail;
        }

        private OrderSubscriptionItem GetSecondOrderSubscriptionItem(int weekId)
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
                OrderSubscriptionId = MyOrders.Max(x => x.OrderSubscriptionId) + 1,
                ClientOrderReviewSentClientOrderReviewSentId = new SubscriptionHelper().CreateOrderReview(selectedDish, MyOrders.Max(x => x.OrderSubscriptionId) + 1).ClientOrderToReviewId,
                WeekId = weekId,
                ScheduledDate = DateTime.Today.Date.AddDays(2)
            };

            //Required Side
            var secondOrderDetailOption = new OrderSubscriptionItemDishOption
            {
                OrderSubscriptionItemDishOptionId = 3,
                DishOptionChoiceId = 14,
                DishOptionChoiceValue = "New York Strip Steak",
                DishOptionId = (int)DishOptionType.Values.FakeRequiredSideThreeOptionChoices,
                Instructions = "no Mayone Please",
                OrderSubscriptionItemId = 2
            };
            secondSubscriptionOrderItemDetail.OrderSubscriptionItemDishOptions.Add(secondOrderDetailOption);
            return secondSubscriptionOrderItemDetail;
        }

        private OrderSubscriptionItem GetThirdOrderSubscriptionItem(int weekId)
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
                OrderSubscriptionId = MyOrders.Max(x => x.OrderSubscriptionId) + 1,
                ClientOrderReviewSentClientOrderReviewSentId = new SubscriptionHelper().CreateOrderReview(selectedDish, MyOrders.Max(x => x.OrderSubscriptionId) + 1).ClientOrderToReviewId,
                WeekId = weekId,
                ScheduledDate = DateTime.Today.Date.AddDays(4)
            };
            return thirdSubscriptionOrderItemDetail;
        }

        private OrderSubscriptionItem GetFourthOrderSubscriptionItem(int weekId)
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
                OrderSubscriptionId = MyOrders.Max(x => x.OrderSubscriptionId) + 1,
                ClientOrderReviewSentClientOrderReviewSentId =  new SubscriptionHelper().CreateOrderReview(selectedDish, MyOrders.Max(x => x.OrderSubscriptionId) + 1).ClientOrderToReviewId,
                WeekId = weekId,
                ScheduledDate = DateTime.Today.Date.AddDays(1)
            };
            return fourthSubscriptionOrderItemDetail;
        }

        #endregion


        #endregion

        #endregion
    }
}
