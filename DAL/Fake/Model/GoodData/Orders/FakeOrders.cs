using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Orders.Clients.Client1;
using DAL.Fake.Model.GoodData.Orders.Clients.Client2;
using DAL.Fake.Model.GoodData.Orders.Clients.Client3;
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
            MyOrders = new List<Order>();
            var client1Orders = new FakeClient1Order().MyOrders;
            foreach (var order in client1Orders)
            {
                MyOrders.Add(order);
            }
            var client2Orders = new FakeClient2Order().MyOrders;
            foreach (var order in client2Orders)
            {
                MyOrders.Add(order);
            }
            var client3Orders = new FakeClient3Order().MyOrders;
            foreach (var order in client3Orders)
            {
                MyOrders.Add(order);
            }

        }

        //ALL 
        #region Client 1 Orders

        #region FirstOrder
        //Pick Up
        //Client 1 
        //Cooker 1
        //Order 1
        //Dish 1 ( 8.00) * 2
        //OrderItemDishOptionId 1,  ( 2. 09)  * 2
        //OrderItemDishOptionId 2, ( 0)  * 2
        //+
        //Dish2 (7.99)
        //OrderItemDishOptionId 3 + 8.97
        #endregion

        #endregion

        #region Client 2 Orders

        #region FirstOrder
        //FirstOrder
        //Delivery
        //Client 2 
        //Cooker 1
        // Order 2
        //Dish 4 ( 10.00)
        // OrderItemDishOptionId 3  (0.53)
        #endregion

        #endregion

        #region Client 3 Orders

        #region FirstOrder
        //Delivery
        // Client 3 
        // Cooker 3
        // Order 3
        // Dish 32 (5.99)
        #endregion

        #endregion


        //$25.62
        //Delivery Fee:
        //$7.64
        //Sales Tax:
        //$3.33

        ~FakeOrders()
        {
            MyOrders = null;
        }
    }
}
