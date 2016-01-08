﻿using System.Collections.Generic;
using DAL.Fake.Model.GoodData.OrdersHistory.Clients.Client1;
using DAL.Fake.Model.GoodData.OrdersHistory.Clients.Client2;
using DAL.Fake.Model.GoodData.OrdersHistory.Clients.Client3;
using Model;

namespace DAL.Fake.Model.GoodData.OrdersHistory.Clients
{
    public class FakeClientsOrdersHistory
    {
        public List<OrderHistroy> MyOrdersHistory;

        public FakeClientsOrdersHistory()
        {
            InitializeOrderHistoryList();
        }

        public void InitializeOrderHistoryList()
        {
            MyOrdersHistory = new List<OrderHistroy>();
            var client1OrdersHistory = new FakeClient1OrderHistory().MyClient1OrdersHistory;
            foreach (var orderHistory in client1OrdersHistory)
            {
                MyOrdersHistory.Add(orderHistory);
            }
            var client2OrdersHistory = new FakeClient2OrderHistory().MyClient2OrdersHistory;
            foreach (var orderHistory in client2OrdersHistory)
            {
                MyOrdersHistory.Add(orderHistory);
            }
            var client3OrdersHistory = new FakeClient3OrderHistory().MyClient3OrdersHistory;
            foreach (var orderHistory in client1OrdersHistory)
            {
                MyOrdersHistory.Add(orderHistory);
            }

        }
        ~FakeClientsOrdersHistory()
        {
            MyOrdersHistory = null;
        }
    }
}
