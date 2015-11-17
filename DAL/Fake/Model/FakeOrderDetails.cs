using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeRefundStatus
    {
        public List<Client> MyClients;

        public FakeRefundStatus()
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

        ~FakeRefundStatus()
        {
            MyClients = null;
        }
    }
}
