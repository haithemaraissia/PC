using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Clients.Address.Client2
{
    public class FakeClient2Address
    {
        public List<ClientAddress> MyClient2Address;

        public FakeClient2Address()
        {
            InitializeUserList();
        }

        public void InitializeUserList()
        {
            MyClient2Address = new List<ClientAddress> {
                FirstclientAddress(), 
                SecondclientAddress(),
                ThirdclientAddress()
            };
        }

        //Address 2
        public ClientAddress FirstclientAddress()
        {
            var firstclientAddress = new ClientAddress
            {
                AddressId = 4,
                ClientId = 2,
                Address = "611 Cortez Street",
                Apt_suite = null,
                CityId = 2,
                RegionId = 2,
                CountryId = 2,
                ZipCode = "66226",
                PhoneNumber = "9234523224",
                Cross_Stree = null,
                Instructions = null,
                AddressTypeId = 1

            };
            return firstclientAddress;
        }

        //Address 2
        public ClientAddress SecondclientAddress()
        {
            var secondclientAddress = new ClientAddress
            {
                AddressId = 5,
                ClientId = 2,
                Address = "12105 south BlockBob",
                Apt_suite = "602",
                CityId = 2,
                RegionId = 2,
                CountryId = 2,
                ZipCode = "66206",
                PhoneNumber = "8267562020",
                Cross_Stree = "Accross from restaurant",
                Instructions = "Ring the bell twice",
                AddressTypeId = 2

            };
            return secondclientAddress;
        }

        //Address 3
        public ClientAddress ThirdclientAddress()
        {
            var thirdclientAddress = new ClientAddress
            {
                AddressId = 6,
                ClientId = 2,
                Address = "10100 South West Boulevard",
                Apt_suite = null,
                CityId = 2,
                RegionId = 2,
                CountryId = 2,
                ZipCode = "66206",
                PhoneNumber = "7562023224",
                Cross_Stree = null,
                Instructions = null,
                AddressTypeId = 3

            };
            return thirdclientAddress;
        }

        ~FakeClient2Address()
        {
            MyClient2Address = null;
        }
    }
}
