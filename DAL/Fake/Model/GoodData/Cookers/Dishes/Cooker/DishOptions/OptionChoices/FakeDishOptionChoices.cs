using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Cookers.Dishes.Cooker.DishOptions.OptionChoices.Optional;
using DAL.Fake.Model.GoodData.Cookers.Dishes.Cooker.DishOptions.OptionChoices.Required;
using Model;

namespace DAL.Fake.Model.GoodData.Cookers.Dishes.Cooker.DishOptions.OptionChoices
{
    public class FakeDishOptionChoices
    {
        public List<DishOptionsChoice> MyDishOptionsChoices;

        public FakeDishOptionChoices()
        {
            InitializeDishOptionsChoicesList();
        }

        public void InitializeDishOptionsChoicesList()
        {
            MyDishOptionsChoices = new List<DishOptionsChoice>();
            var threeSideOptionalChoices = new FakeOptionalSideThreeOptionChoices().MyDishOptionsChoices;
            var fourSideOptionalChoices = new FakeOptionalSideFourOptionChoices().MyDishOptionsChoices;
            var threeSideRequiredChoices = new FakeRequiredSideThreeOptionChoices().MyDishOptionsChoices;
            var twelveSideRequiredChoices = new FakeRequiredSideOptionChoices().MyDishOptionsChoices;

            foreach (var dishOptionsChoice in threeSideOptionalChoices)
            {
                MyDishOptionsChoices.Add(dishOptionsChoice);
            }
            foreach (var dishOptionsChoice in fourSideOptionalChoices)
            {
                MyDishOptionsChoices.Add(dishOptionsChoice);
            }
            foreach (var dishOptionsChoice in threeSideRequiredChoices)
            {
                MyDishOptionsChoices.Add(dishOptionsChoice);
            }
            foreach (var dishOptionsChoice in twelveSideRequiredChoices)
            {
                MyDishOptionsChoices.Add(dishOptionsChoice);
            }
        }

        ~FakeDishOptionChoices()
        {
            MyDishOptionsChoices = null;
        }

    }
}
