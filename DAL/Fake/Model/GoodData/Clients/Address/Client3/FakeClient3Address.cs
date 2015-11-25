using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Clients.Address.Client3
{
    public class FakeClient3Address
    {
        public List<ClientAddress> MyClient3Address;

        public FakeClient3Address()
        {
            InitializeUserList();
        }

        public void InitializeUserList()
        {
            MyClient3Address = new List<ClientAddress> {
                FirstclientAddress(), 
                SecondclientAddress(),
                ThirdclientAddress()
            };
        }

        //Address 3
        public ClientAddress FirstclientAddress()
        {
            var firstclientAddress = new ClientAddress
            {
                AddressId = 7,
                ClientId = 3,
                Address = "6805 main Street",
                Apt_suite = null,
                CityId = 3,
                RegionId = 3,
                CountryId = 3,
                ZipCode = "66236",
                PhoneNumber = "9334533234",
                Cross_Stree = null,
                Instructions = null,
                AddressTypeId = 3

            };
            return firstclientAddress;
        }

        //Address 2
        public ClientAddress SecondclientAddress()
        {
            var secondclientAddress = new ClientAddress
            {
                AddressId = 8,
                ClientId = 3,
                Address = "4805 Main Street",
                Apt_suite = "603",
                CityId = 3,
                RegionId = 3,
                CountryId = 3,
                ZipCode = "66206",
                PhoneNumber = "8367563030",
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
                AddressId = 9,
                ClientId = 3,
                Address = "33203 South West Boulevard",
                Apt_suite = null,
                CityId = 3,
                RegionId = 3,
                CountryId = 3,
                ZipCode = "66206",
                PhoneNumber = "7563023234",
                Cross_Stree = null,
                Instructions = null,
                AddressTypeId = 3

            };
            return thirdclientAddress;
        }

        ~FakeClient3Address()
        {
            MyClient3Address = null;
        }
    }
}
