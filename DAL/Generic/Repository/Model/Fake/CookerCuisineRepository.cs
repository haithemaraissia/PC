using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerCuisineRepository : FakeGenericRepository<CookerCuisine>, ICookerCuisineRepository
    {
	    public FakeCookerCuisineRepository(): base(new FakeCookerCuisines().MyCookerCuisines)
        {
        }

        public FakeCookerCuisineRepository(List<CookerCuisine> myCookerCuisines)
            : base(myCookerCuisines)
        {
        }
    }
}
       