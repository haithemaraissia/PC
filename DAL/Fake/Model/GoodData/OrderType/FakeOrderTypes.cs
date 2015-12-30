using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.OrderType
{
    public class FakeOrderTypes
    {
        public List<global::Model.OrderType> MyOrderTypes;

        public FakeOrderTypes()
        {
            InitializeOrderTypeList();
        }

        public void InitializeOrderTypeList()
        {
            MyOrderTypes = new List<global::Model.OrderType> {
                FirstOrderType(), 
                SecondOrderType()
            };
        }

        public global::Model.OrderType FirstOrderType()
        {
            var firstOrderType = new global::Model.OrderType
            {
                OrderTypeId = (int)Util.OrderType.Values.PickUp,
                OrderTypeValue = "Pick Up"
            };
            return firstOrderType;
        }

        public global::Model.OrderType SecondOrderType()
        {
            var secondOrderType = new global::Model.OrderType
            {
                OrderTypeId = (int)Util.OrderType.Values.Delivery,
                OrderTypeValue = "Delivery"
            };
            return secondOrderType;
        }

        ~FakeOrderTypes()
        {
            MyOrderTypes = null;
        }
    }
}
