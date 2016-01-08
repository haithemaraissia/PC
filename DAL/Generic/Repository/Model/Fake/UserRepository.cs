using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class UserRepository : FakeGenericRepository<User>, IUserRepository
    {
	    public UserRepository(): base(new FakeUsers().MyUsers)
        {
        }

        public UserRepository(List<User> myUsers): base(myUsers)
        {
        }
    }
}
       