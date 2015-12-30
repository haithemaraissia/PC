using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.OrderModelType
{
    public class FakeOrderModelTypes
    {

        public List<global::Model.OrderModelType> MyOrderModelTypeTypes;

        public FakeOrderModelTypes()
        {
            InitializeOrderModelTypeTypeList();
        }

        public void InitializeOrderModelTypeTypeList()
        {
            MyOrderModelTypeTypes = new List<global::Model.OrderModelType> {
                FirstOrderModelTypeType(), 
                SecondOrderModelTypeType()
            };
        }

        public global::Model.OrderModelType FirstOrderModelTypeType()
        {
            var firstOrderModelTypeType = new global::Model.OrderModelType
            {
                OrderModelTypeId = (int)Util.OrderModelType.Values.Transaction,
                OrderModelTypeValue = Util.OrderModelType.Values.Transaction.ToString()
            };
            return firstOrderModelTypeType;
        }

        public global::Model.OrderModelType SecondOrderModelTypeType()
        {
            var secondOrderModelTypeType = new global::Model.OrderModelType
            {
                OrderModelTypeId = (int)Util.OrderModelType.Values.Subscription,
                OrderModelTypeValue = Util.OrderModelType.Values.Subscription.ToString()
            };
            return secondOrderModelTypeType;
        }


        ~FakeOrderModelTypes()
        {
            MyOrderModelTypeTypes = null;
        }
    }
}
