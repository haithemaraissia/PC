using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Client
{
    public class FakeClients
    {
        public List<global::Model.Client> MyClients;

        public FakeClients()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyClients = new List<global::Model.Client> {
                FirstClient(), 
                SecondClient(),
                ThirdClient()
            };
        }

        public global::Model.Client FirstClient()
        {
            var firstClient = new global::Model.Client
            {
                ClientId = 1,
                UserId = 3
            };
            return firstClient;
        }

        public global::Model.Client SecondClient()
        {
            var secondClient = new global::Model.Client
            {
                ClientId = 2,
                UserId = 4
            };
            return secondClient;
        }

        public global::Model.Client ThirdClient()
        {
            var thirdClient = new global::Model.Client
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
