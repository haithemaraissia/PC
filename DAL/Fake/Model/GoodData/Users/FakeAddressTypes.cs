using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Users
{
    public class FakeAddressTypes
    {
        public List<AddressType> MyAddressTypes;

        public FakeAddressTypes()
        {
            InitializeAddressTypeList();
        }

        public void InitializeAddressTypeList()
        {
            MyAddressTypes = new List<AddressType> {
                FirstAddressType(), 
                SecondAddressType(),
                ThirdAddressType()
            };
        }

        public AddressType FirstAddressType()
        {
            var firstAddressType = new AddressType
            {
                AddressTypeId = 1,
                AddressTypeValue = LookUp.Address.AddressType.Values.Home.ToString()
            };
            return firstAddressType;
        }

        public AddressType SecondAddressType()
        {
            var secondAddressType = new AddressType
            {
                AddressTypeId = 2,
                AddressTypeValue = LookUp.Address.AddressType.Values.Work.ToString()
            };
            return secondAddressType;
        }

        public AddressType ThirdAddressType()
        {
            var thirdAddressType = new AddressType
            {
                AddressTypeId = 3,
                AddressTypeValue = LookUp.Address.AddressType.Values.Other.ToString()
            };
            return thirdAddressType;
        }

        ~FakeAddressTypes()
        {
            MyAddressTypes = null;
        }
    }
}
