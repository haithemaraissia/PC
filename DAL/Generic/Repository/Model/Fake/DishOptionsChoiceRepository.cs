using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers.Dishes.Cooker.DishOptions.OptionChoices;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeDishOptionsChoiceRepository : FakeGenericRepository<DishOptionsChoice>, IDishOptionsChoiceRepository
    {
        public FakeDishOptionsChoiceRepository() : base(new FakeDishOptionChoices().MyDishOptionsChoices)
        {
        }

        public FakeDishOptionsChoiceRepository(List<DishOptionsChoice> myDishOptionsChoices)
            : base(myDishOptionsChoices)
        {
        }
    }
}
