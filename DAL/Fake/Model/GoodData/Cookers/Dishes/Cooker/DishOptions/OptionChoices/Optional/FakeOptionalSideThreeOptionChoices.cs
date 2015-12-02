using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker.DishOptions.OptionChoices.Optional
{
    public class FakeOptionalSideThreeOptionChoices 
    {
        public List<DishOptionsChoice> MyDishOptionsChoices;

        public FakeOptionalSideThreeOptionChoices ()
        {
            InitializeDishOptionsChoiceList();
        }

        public void InitializeDishOptionsChoiceList()
        {
            MyDishOptionsChoices = new List<DishOptionsChoice> {
                FirstDishOptionsChoice(), 
                SecondDishOptionsChoice(),
                ThirdDishOptionsChoice(),
            };
        }

        public DishOptionsChoice FirstDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 16,
                DishOptionChoiceValue = "Miso Soup",
                Price = null,
                CurrencyId = null,
                DishOptionId = (int)Util.DishOptionType.Values.FakeOptionalSideThreeOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice SecondDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 17,
                DishOptionChoiceValue = "House Salad",
                Price = null,
                CurrencyId = null,
               DishOptionId = (int)Util.DishOptionType.Values.FakeOptionalSideThreeOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice ThirdDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 18,
                DishOptionChoiceValue = "Miso Soup and House Salad",
                Price = null,
                CurrencyId = null,
               DishOptionId = (int)Util.DishOptionType.Values.FakeOptionalSideThreeOptionChoices
            };
            return dishOptionsChoice;
        }

        ~FakeOptionalSideThreeOptionChoices()
        {
            MyDishOptionsChoices = null;
        }
    }
}
