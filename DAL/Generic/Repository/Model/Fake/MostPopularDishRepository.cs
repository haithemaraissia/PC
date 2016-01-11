using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.MostPopularDish;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeMostPopularDishRepository : FakeGenericRepository<MostPopularDish>, IMostPopularDishRepository
    {
	    public FakeMostPopularDishRepository(): base(new FakeMostPopularDishes().MyMostPopularDishes)
        {
        }

        public FakeMostPopularDishRepository(List<MostPopularDish> myMostPopularDishs)
            : base(myMostPopularDishs)
        {
        }
    }
}
       