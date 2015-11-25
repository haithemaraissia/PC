using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Clients.Address.Client1;
using DAL.Fake.Model.GoodData.Clients.Address.Client2;
using DAL.Fake.Model.GoodData.Clients.Address.Client3;
using Model;

namespace DAL.Fake.Model.GoodData.Clients.Address
{
    public class FakeClientAddress
    {
        public List<ClientAddress> MyClientAddress;

        public FakeClientAddress()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyClientAddress = new List<ClientAddress>();
            var client1Address = new FakeClient1Address().MyClient1Address;
            foreach (var address in client1Address)
            {
                MyClientAddress.Add(address);
            }
            var client2Address = new FakeClient2Address().MyClient2Address;
            foreach (var address in client2Address)
            {
                MyClientAddress.Add(address);
            }
            var client3Address = new FakeClient3Address().MyClient3Address;
            foreach (var address in client3Address)
            {
                MyClientAddress.Add(address);
            }
        }

        ~FakeClientAddress()
        {
            MyClientAddress = null;
        }
    }
}
