using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Users;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class AddressTypeRepository : FakeGenericRepository<AddressType>, IAddressTypeRepository
    {
	    public AddressTypeRepository(): base(new FakeAddressTypes().MyAddressTypes)
        {
        }

        public AddressTypeRepository(List<AddressType> myAddressTypes): base(myAddressTypes)
        {
        }
    }
}
       