using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Users;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeUserTypeRepository : FakeGenericRepository<UserType>, IUserTypeRepository
    {
	    public FakeUserTypeRepository(): base(new FakeUserTypes().MyUserTypes)
        {
        }

        public FakeUserTypeRepository(List<UserType> myUserTypes)
            : base(myUserTypes)
        {
        }
    }
}
       