using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Orders.Clients.Client2
{
    public class FakeClient2OrderHistory
    {
        public List<OrderHistroy> MyClient2OrdersHistory;

        public FakeClient2OrderHistory()
        {
            InitializeClient2OrderHistoryList();
        }

        private void InitializeClient2OrderHistoryList()
        {
            MyClient2OrdersHistory = new List<OrderHistroy> {
                FirstOrderHistory()
            };
        }

        private OrderHistroy FirstOrderHistory()
        {
            throw new NotImplementedException();
        }

        ~FakeClient2OrderHistory()
        {
            MyClient2OrdersHistory = null;
        }
    }
}
