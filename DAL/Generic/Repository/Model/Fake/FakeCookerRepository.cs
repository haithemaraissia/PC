using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model
{
    public class FakeCookerRepository : FakeGenericRepository<Cooker>, Data.Repo.IRepository.ICookerRepository
    {
        public FakeCookerRepository(): base(new FakeCookers().MyCookers)
        {
        }

        public FakeCookerRepository(List<Cooker> myCookers): base(myCookers)
        {
        }

    }
}
