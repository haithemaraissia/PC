using System;
using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.Orders.Clients.Client1
{
    public class FakeClient1Order
    {
        public List<Order> MyOrders;

        public FakeClient1Order()
        {
            InitializeOrderList();
        }

        private void InitializeOrderList()
        {
            MyOrders = new List<Order> {
                FirstOrder()
            };
        }

        #region From Cooker1

        #region First Order

        //Pick Up
        //Client 1 
        // Cooker 1
        //Order 1
        //Dish 1 ( 8.00) * 2
        //OrderItemDishOptionId 1,  ( 2. 09)  * 2
        //OrderItemDishOptionId 2, ( 0)  * 2

        //+
        //Dish2 (7.99)
        //OrderItemDishOptionId 3 + 8.97

        public Order FirstOrder()
        {
            var firstOrder = new Order
            {
                OrderId = 1,
                ClientId = 1,
                OrderDate = DateTime.Today.Date,
                DeliveryDate = null,
                OrderTypeId = (int)Util.OrderType.Values.PickUp,
                PaymentMethodId = (int)PaymentMethodType.Values.CardOnLine,
                CouponId = null,
                PromotionId = null,
                PlanId = null,
                CurrencyId = (int)CurrencyType.Values.Usd,
                SubTotal = (decimal)37.14
            };
            firstOrder.OrderItems.Add(new FakeOrderItems().GetClient1FirstOrderFirstOrderItem());
            firstOrder.OrderItems.Add(new FakeOrderItems().GetClient1FirstOrderSecondOrderItem()); 
            return firstOrder;
        }

        #region OrderItems

        private OrderItem GetFirstOrderItem()
        {
            var firstOrderDetail = new OrderItem
            {
                CookerId = 1,
                Description = "Chicken sauteed with roasted red peppers in our marinara sauce with provolone cheese. Served on fresh white Italian braided rolls topped with sesame seeds.",
                DishId = 1,
                Instructions = "Put Extra French Fries",
                MenuId = 1,
                OrderItemId = 1,
                Quantity = 2
            };

            //Required Side
            var firstOrderDetailOption = new OrderItemDishOption
            {
                OrderItemDishOptionId = 1,
                DishOptionChoiceId = 3,
                DishOptionChoiceValue = "Cucumber Salad",
                Price = (decimal?)2.09,
                CurrencyId = 1,
                DishOptionId = (int)DishOptionType.Values.FakeRequiredSideTwelveOptionChoices,
                Instructions = "no Mayone Please",
                OrderItemId = 1
            };

            //Optional Side
            var secondOrderDetailOption = new OrderItemDishOption
            {
                OrderItemDishOptionId = 2,
                DishOptionChoiceId = 17,
                DishOptionChoiceValue = "House Salad",
                Price = null,
                CurrencyId = null,
                DishOptionId = (int)DishOptionType.Values.FakeOptionalSideThreeOptionChoices,
                Instructions = "More Lettuce",
                OrderItemId = 1
            };
            firstOrderDetail.OrderItemDishOptions.Add(firstOrderDetailOption);
            firstOrderDetail.OrderItemDishOptions.Add(secondOrderDetailOption);
            return firstOrderDetail;
        }

        private OrderItem GetSecondOrderItem()
        {
            var secondOrderDetail = new OrderItem
            {
                CookerId = 1,
                Description = "Home made pasta, ground beef, tomato sauce, bechamel sauce and parmesan.",
                DishId = 3,
                Instructions = "Put Extra Spices",
                MenuId = 1,
                OrderItemId = 2,
                Quantity = 1
            };

            //Required Side
            var firstOrderDetailOption = new OrderItemDishOption
            {
                OrderItemDishOptionId = 3,
                DishOptionChoiceId = 14,
                DishOptionChoiceValue = "New York Strip Steak",
                Price = (decimal?)8.97,
                CurrencyId = 1,
                DishOptionId = (int)DishOptionType.Values.FakeRequiredSideThreeOptionChoices,
                Instructions = "no Mayone Please",
                OrderItemId = 2
            };
            secondOrderDetail.OrderItemDishOptions.Add(firstOrderDetailOption);
            return secondOrderDetail;
        }

        #endregion



        #endregion

        #endregion
    }
}
