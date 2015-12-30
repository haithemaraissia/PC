using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Orders.Clients.Client3
{
    public class FakeClient3Order
    {
        public List<Order> MyOrders;

        public FakeClient3Order()
        {
            InitializeOrderList();
        }

        private void InitializeOrderList()
        {
            MyOrders = new List<Order> {
                FirstOrder()
            };
        }



        #region First Order

        //Delivery
        // Client 3 
        // Cooker 3
        // Order 3
        // Dish 32 (5.99)

        private Order FirstOrder()
        {
            var firstOrder = new Order
            {
                OrderId = 3,
                ClientId = 3,
                OrderDate = DateTime.Today.Date,
                DeliveryDate = null,
                OrderTypeId = (int)Util.OrderType.Values.Delivery,
                PaymentMethodId = (int)Util.PaymentMethodType.Values.Cash,
                PromotionId = null,
                CouponId = null,
                PlanId = null,
                SubTotal = (decimal)5.99
            };
            firstOrder.OrderItems.Add(new FakeOrderItems().GetClient3FirstOrderFirstOrderItem());
            return firstOrder;
        }


        #endregion
    }
}
