using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CuisineTypeRepository : FakeGenericRepository<CuisineType>, ICuisineTypeRepository
    {
	    public CuisineTypeRepository(): base(new FakeCuisineTypes().MyCuisineTypes)
        {
        }

        public CuisineTypeRepository(List<CuisineType> myCuisineTypes): base(myCuisineTypes)
        {
        }
    }
}
       