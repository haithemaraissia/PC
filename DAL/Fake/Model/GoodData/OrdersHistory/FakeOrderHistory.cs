using System.Collections.Generic;
using DAL.Fake.Model.GoodData.OrdersHistory.Clients;
using Model;

namespace DAL.Fake.Model.GoodData.OrdersHistory
{
    public class FakeOrdersHistory
    {
        public List<OrderHistroy> MyOrdersHistory;

        public FakeOrdersHistory()
        {
            InitializeOrderList();
        }

        public void InitializeOrderList()
        {
            MyOrdersHistory = new List<OrderHistroy>();
            var clientsOrdersHistory = new FakeClientsOrdersHistory().MyOrdersHistory;
            foreach (var ordersHistory in clientsOrdersHistory)
            {
                MyOrdersHistory.Add(ordersHistory);
            }

            //Same for Cookers

        }

        ~FakeOrdersHistory()
        {
            MyOrdersHistory = null;
        }
    }
}
