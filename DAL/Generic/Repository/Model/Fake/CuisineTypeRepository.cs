using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cuisines;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCuisineTypeRepository : FakeGenericRepository<CuisineType>, ICuisineTypeRepository
    {
	    public FakeCuisineTypeRepository(): base(new FakeCuisineTypes().MyCuisineTypes)
        {
        }

        public FakeCuisineTypeRepository(List<CuisineType> myCuisineTypes)
            : base(myCuisineTypes)
        {
        }
    }
}
       