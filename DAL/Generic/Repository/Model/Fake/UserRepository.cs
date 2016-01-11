using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Users;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeUserRepository : FakeGenericRepository<User>, IUserRepository
    {
	    public FakeUserRepository(): base(new FakeUsers().MyUsers)
        {
        }

        public FakeUserRepository(List<User> myUsers)
            : base(myUsers)
        {
        }
    }
}
       