using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class DishRepository : FakeGenericRepository<Dish>, IDishRepository
    {
	    public DishRepository(): base(new FakeDishs().MyDishs)
        {
        }

        public DishRepository(List<Dish> myDishs): base(myDishs)
        {
        }
    }
}
       