using System;
using System.Collections.Generic;
using DAL.Fake.Model.GoodData.OrderItems;
using DAL.Fake.Model.LookUp.Currency;
using DAL.Fake.Model.LookUp.OrderStatu;
using DAL.Fake.Model.LookUp.PaymentMethod;
using Model;
using OrderType = DAL.Fake.Model.LookUp.OrderType.OrderType;

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
                OrderTypeId = (int)OrderType.Values.PickUp,
                PaymentMethodId = (int)PaymentMethodType.Values.CardOnLine,
                CouponId = null,
                PromotionId = null,
                PlanId = null,
                CurrencyId = (int)CurrencyType.Values.Usd,
                SubTotal = (decimal)37.14,
                OrderStatusId = (int)OrderStatus.Values.Submitted,
            };
            firstOrder.OrderItems.Add(new FakeOrderItems().GetClient1FirstOrderFirstOrderItem());
            firstOrder.OrderItems.Add(new FakeOrderItems().GetClient1FirstOrderSecondOrderItem()); 
            return firstOrder;
        }

        #region OrderItems

        #endregion



        #endregion

        #endregion
    }
}
