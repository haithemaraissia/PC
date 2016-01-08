using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerCuisineRepository : FakeGenericRepository<CookerCuisine>, ICookerCuisineRepository
    {
	    public CookerCuisineRepository(): base(new FakeCookerCuisines().MyCookerCuisines)
        {
        }

        public CookerCuisineRepository(List<CookerCuisine> myCookerCuisines): base(myCookerCuisines)
        {
        }
    }
}
       