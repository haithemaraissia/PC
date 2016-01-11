using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.OrderTypes
{
    public class FakeOrderTypes
    {
        public List<OrderType> MyOrderTypes;

        public FakeOrderTypes()
        {
            InitializeOrderTypeList();
        }

        public void InitializeOrderTypeList()
        {
            MyOrderTypes = new List<OrderType> {
                FirstOrderType(), 
                SecondOrderType()
            };
        }

        public OrderType FirstOrderType()
        {
            var firstOrderType = new OrderType
            {
                OrderTypeId = (int)LookUp.OrderType.OrderType.Values.PickUp,
                OrderTypeValue = LookUp.OrderType.OrderType.Values.PickUp.ToString()
            };
            return firstOrderType;
        }

        public OrderType SecondOrderType()
        {
            var secondOrderType = new OrderType
            {
                OrderTypeId = (int)LookUp.OrderType.OrderType.Values.Delivery,
                OrderTypeValue = LookUp.OrderType.OrderType.Values.Delivery.ToString()
            };
            return secondOrderType;
        }

        ~FakeOrderTypes()
        {
            MyOrderTypes = null;
        }
    }
}
