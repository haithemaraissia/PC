using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Clients.Address.Client1
{
    public class FakeClient1Address
    {
        public List<ClientAddress> MyClient1Address;

        public FakeClient1Address()
        {
            InitializeUserList();
        }

        public void InitializeUserList()
        {
            MyClient1Address = new List<ClientAddress> {
                FirstclientAddress(), 
                SecondclientAddress(),
                ThirdclientAddress()
            };
        }

        //Address 1
        public ClientAddress FirstclientAddress()
        {
            var firstclientAddress = new ClientAddress
            {
                AddressId = 1,
                ClientId = 1,
                Address = "6805 main Street",
                Apt_suite = null,
                CityId = 1,
                RegionId = 1,
                CountryId = 1,
                ZipCode = "66216",
                PhoneNumber = "9134513214",
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
                AddressId = 1,
                ClientId = 1,
                Address = "4805 Main Street",
                Apt_suite = "601",
                CityId = 1,
                RegionId = 1,
                CountryId = 1,
                ZipCode = "66206",
                PhoneNumber = "8167561010",
                Cross_Stree = "Accross from Library",
                Instructions = "Ring the bell",
                AddressTypeId = 2

            };
            return secondclientAddress;
        }

        //Address 3
        public ClientAddress ThirdclientAddress()
        {
            var thirdclientAddress = new ClientAddress
            {
                AddressId = 1,
                ClientId = 1,
                Address = "11201 South West Boulevard",
                Apt_suite = null,
                CityId = 1,
                RegionId = 1,
                CountryId = 1,
                ZipCode = "66206",
                PhoneNumber = "7561023214",
                Cross_Stree = null,
                Instructions = null,
                AddressTypeId = 3

            };
            return thirdclientAddress;
        }

        ~FakeClient1Address()
        {
            MyClient1Address = null;
        }
    }
}
