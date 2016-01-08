using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class UserTypeRepository : FakeGenericRepository<UserType>, IUserTypeRepository
    {
	    public UserTypeRepository(): base(new FakeUserTypes().MyUserTypes)
        {
        }

        public UserTypeRepository(List<UserType> myUserTypes): base(myUserTypes)
        {
        }
    }
}
       