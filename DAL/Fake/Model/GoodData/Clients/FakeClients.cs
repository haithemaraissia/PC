using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Clients
{
    public class FakeClients
    {
        public List<Client> MyClients;

        public FakeClients()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyClients = new List<Client> {
                FirstClient(), 
                SecondClient(),
                ThirdClient()
            };
        }

        public Client FirstClient()
        {
            var firstClient = new Client
            {
                ClientId = 1,
                UserId = 3
            };
            return firstClient;
        }

        public Client SecondClient()
        {
            var secondClient = new Client
            {
                ClientId = 2,
                UserId = 4
            };
            return secondClient;
        }

        public Client ThirdClient()
        {
            var thirdClient = new Client
            {
                ClientId = 3,
                UserId = 6
            };
            return thirdClient;
        }

        ~FakeClients()
        {
            MyClients = null;
        }
    }
}
