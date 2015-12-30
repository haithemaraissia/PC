using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using DAL.Fake.Model.GoodData.Cooker;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeCookerRepository : FakeGenericRepository<Cooker>, ICookerRepository
    {
        public FakeCookerRepository(): base(new FakeCookers().MyCookers)
        {
        }

        public FakeCookerRepository(List<Cooker> myCookers): base(myCookers)
        {
        }

    }
}
