using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Users;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeAddressTypeRepository : FakeGenericRepository<AddressType>, IAddressTypeRepository
    {
	    public FakeAddressTypeRepository(): base(new FakeAddressTypes().MyAddressTypes)
        {
        }

        public FakeAddressTypeRepository(List<AddressType> myAddressTypes)
            : base(myAddressTypes)
        {
        }
    }
}
       