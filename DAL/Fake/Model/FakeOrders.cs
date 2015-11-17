using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeOrders
    {
        public List<Order> MyOrders;

        public FakeOrders()
        {
            InitializeOrderList();
        }

        public void InitializeOrderList()
        {
            MyOrders = new List<Order> {
                FirstOrder(), 
                SecondOrder(),
                ThirdOrder()
            };
        }

        public Order FirstOrder()
        {
            var firstOrder = new Order
            {
                OrderId = 1,
                ClientId = 1,
                CookerId = 1,
                Description = "First Order",
                MenuId = 1,
                Quantity=3,
                OrderDate= DateTime.Today,
                DeliveryDate = DateTime.Today
            };
            return firstOrder;
        }

        public Order SecondOrder()
        {
            var secondOrder = new Order
            {
                OrderId = 2,
                ClientId = 1,
                CookerId = 1,
                Description = "Second Order",
                MenuId = 1,
                Quantity = 3,
                OrderDate = DateTime.Today,
                DeliveryDate = DateTime.Today
            };
            return secondOrder;
        }

        public Order ThirdOrder()
        {
            var thirdOrder = new Order
            {
                OrderId = 3,
                ClientId = 1,
                CookerId = 1,
                Description = "Third Order",
                MenuId = 1,
                Quantity = 3,
                OrderDate = DateTime.Today,
                DeliveryDate = DateTime.Today
            };
            return thirdOrder;
        }

        ~FakeOrders()
        {
            MyOrders = null;
        }
    }
}
