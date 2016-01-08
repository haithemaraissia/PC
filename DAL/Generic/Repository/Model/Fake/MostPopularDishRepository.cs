using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class MostPopularDishRepository : FakeGenericRepository<MostPopularDish>, IMostPopularDishRepository
    {
	    public MostPopularDishRepository(): base(new FakeMostPopularDishs().MyMostPopularDishs)
        {
        }

        public MostPopularDishRepository(List<MostPopularDish> myMostPopularDishs): base(myMostPopularDishs)
        {
        }
    }
}
       