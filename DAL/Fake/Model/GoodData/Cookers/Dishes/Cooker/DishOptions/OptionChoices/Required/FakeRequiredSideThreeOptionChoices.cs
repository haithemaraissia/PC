using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker.DishOptions.OptionChoices.Required
{
    public class FakeRequiredSideThreeOptionChoices
    {
        public List<DishOptionsChoice> MyDishOptionsChoices;

        public FakeRequiredSideThreeOptionChoices()
        {
            InitializeDishOptionsChoiceList();
        }

        public void InitializeDishOptionsChoiceList()
        {
            MyDishOptionsChoices = new List<DishOptionsChoice> {
                FirstDishOptionsChoice(), 
                SecondDishOptionsChoice(),
                ThirdDishOptionsChoice()
            };
        }

        public DishOptionsChoice FirstDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 13,
                DishOptionChoiceValue = "Chicken Breast",
                Price = null,
                CurrencyId = null,
                DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideThreeOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice SecondDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 14,
                DishOptionChoiceValue = "New York Strip Steak",
                Price = (decimal?) 8.97,
                CurrencyId = 1,
                DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideThreeOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice ThirdDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 15,
                DishOptionChoiceValue = "Atlantic Salmon",
                Price = (decimal?) 2.05,
                CurrencyId = 1,
                DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideThreeOptionChoices
            };
            return dishOptionsChoice;
        }

        ~FakeRequiredSideThreeOptionChoices()
        {
            MyDishOptionsChoices = null;
        }
    }
}
