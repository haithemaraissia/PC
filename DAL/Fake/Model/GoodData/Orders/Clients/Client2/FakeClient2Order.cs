using System;
using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.Orders.Clients.Client2
{
    public class FakeClient2Order
    {
        public List<Order> MyOrders;

        public FakeClient2Order()
        {
            InitializeOrderList();
        }

        private void InitializeOrderList()
        {
            MyOrders = new List<Order> {
                FirstOrder()
            };
        }

        #region to Configure
        //if order is certain price 
        //then delivery is free
        #endregion

        #region Second Order

        //Delivery
        //Client 2 
        // Cooker 1
        //  Order 2
        //Dish 4 ( 10.00)
        // OrderItemDishOptionId 3  (0.53)

        private Order FirstOrder()
        {
            var secondOrder = new Order
            {
                OrderId = 2,
                ClientId = 2,
                OrderDate = DateTime.Today.Date,
                DeliveryDate = DateTime.Today.Date,
                OrderTypeId = (int)Util.OrderType.Values.Delivery,
                PaymentMethodId = (int)PaymentMethodType.Values.CardOnLine,
                PromotionId = null,
                CouponId = null,
                PlanId = null,
                SubTotal = (decimal)10.53
            };
            secondOrder.OrderItems.Add(new FakeOrderItems().GetClient2FirstOrderFirstOrderItem());
            return secondOrder;
        }

        



        #endregion
    }
}
