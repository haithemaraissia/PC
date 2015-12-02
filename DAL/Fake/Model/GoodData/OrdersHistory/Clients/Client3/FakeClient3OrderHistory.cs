using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Orders.Clients.Client3
{
    public class FakeClient3OrderHistory
    {
        public List<OrderHistroy> MyClient3OrdersHistory;

        public FakeClient3OrderHistory()
        {
            InitializeClient3OrderHistoryList();
        }

        private void InitializeClient3OrderHistoryList()
        {
            MyClient3OrdersHistory = new List<OrderHistroy> {
                FirstOrderHistory()
            };
        }

        private OrderHistroy FirstOrderHistory()
        {
            throw new NotImplementedException();
        }

        ~FakeClient3OrderHistory()
        {
            MyClient3OrdersHistory = null;
        }
    }
}
