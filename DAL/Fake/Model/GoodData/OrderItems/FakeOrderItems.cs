using System.Collections.Generic;
using DAL.Fake.Model.GoodData.OrderItemDishes;
using Model;

namespace DAL.Fake.Model.GoodData.OrderItems
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

            firstOrderDetail.OrderItemDishOptions.Add(new FakeOrderItemDishOptions().FirstOrderItemDishOption());
            firstOrderDetail.OrderItemDishOptions.Add(new FakeOrderItemDishOptions().SecondOrderItemDishOption());
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
            secondOrderDetail.OrderItemDishOptions.Add(new FakeOrderItemDishOptions().ThirdOrderItemDishOption());
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

            firstOrderDetail.OrderItemDishOptions.Add(new FakeOrderItemDishOptions().FourthOrderItemDishOption());
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
