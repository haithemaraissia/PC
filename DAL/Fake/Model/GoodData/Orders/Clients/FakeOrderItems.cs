using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.Orders.Clients
{
    public class FakeOrderItems
    {
        public List<OrderItem> MyOrderItems;

        public FakeOrderItems()
        {
            InitializeOrderItemList();
        }

        public void InitializeOrderItemList()
        {
            MyOrderItems = new List<OrderItem> {
                GetClient1FirstOrderFirstOrderItem(), GetClient1FirstOrderSecondOrderItem(),
                GetClient2FirstOrderFirstOrderItem(),
                GetClient3FirstOrderFirstOrderItem()
            };
        }


        #region Client1 First Order
        //OrderId = 1
        public OrderItem GetClient1FirstOrderFirstOrderItem()
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
                CurrencyId = (int)CurrencyType.Values.Usd,
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

        public OrderItem GetClient1FirstOrderSecondOrderItem()
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


        #region Client2 First Order
        //OrderId =2

        public OrderItem GetClient2FirstOrderFirstOrderItem()
        {
            var firstOrderDetail = new OrderItem
            {
                CookerId = 1,
                Description = "Includes six pieces.",
                DishId = 4,
                Instructions = null,
                MenuId = 1,
                OrderItemId = 3,
                Quantity = 1
            };

            //Optional Side
            var firstOrderDetailOption = new OrderItemDishOption
            {
                OrderItemDishOptionId = 3,
                DishOptionChoiceId = 20,
                DishOptionChoiceValue = "Extra Dressing",
                Price = (decimal?)0.53,
                CurrencyId = (int)CurrencyType.Values.Usd,
                DishOptionId = (int)DishOptionType.Values.FakeOptionalSideFourOptionChoices,
                Instructions = "no Mayone Please",
                OrderItemId = 3
            };
            firstOrderDetail.OrderItemDishOptions.Add(firstOrderDetailOption);
            return firstOrderDetail;
        }
        #endregion


        #region Client3 First Order
        //OrderId =3
        public OrderItem GetClient3FirstOrderFirstOrderItem()
        {
            var firstOrderDetail = new OrderItem
            {
                CookerId = 3,
                Description = "Saag Pea Soup",
                DishId = 32,
                Instructions = null,
                MenuId = 7,
                OrderItemId = 5,
                Quantity = 1
            };
            return firstOrderDetail;
        }
        #endregion


        ~FakeOrderItems()
        {
            MyOrderItems = null;
        }
    }
}
