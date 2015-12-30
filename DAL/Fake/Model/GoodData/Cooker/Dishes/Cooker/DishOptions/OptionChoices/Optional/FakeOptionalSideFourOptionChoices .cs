using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker.DishOptions.OptionChoices.Optional
{
    public class FakeOptionalSideFourOptionChoices  
    {
        public List<DishOptionsChoice> MyDishOptionsChoices;

        public FakeOptionalSideFourOptionChoices  ()
        {
            InitializeDishOptionsChoiceList();
        }

        public void InitializeDishOptionsChoiceList()
        {
            MyDishOptionsChoices = new List<DishOptionsChoice> {
                FirstDishOptionsChoice(), 
                SecondDishOptionsChoice(),
                ThirdDishOptionsChoice(),
                FourthDishOptionsChoice()
            };
        }

        public DishOptionsChoice FirstDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 19,
                DishOptionChoiceValue = "Add French Fries",
                Price = (decimal?) 2.09,
                CurrencyId = 1,
                DishOptionId = (int)Util.DishOptionType.Values.FakeOptionalSideFourOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice SecondDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 20,
                DishOptionChoiceValue = "Extra Dressing",
                Price = (decimal?) 0.53,
                CurrencyId = 1,
                DishOptionId = (int)Util.DishOptionType.Values.FakeOptionalSideFourOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice ThirdDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 21,
                DishOptionChoiceValue = "Extra BBQ Sauce",
                Price = (decimal?) 0.53,
                CurrencyId = 1,
                DishOptionId = (int)Util.DishOptionType.Values.FakeOptionalSideFourOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice FourthDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 22,
                DishOptionChoiceValue = "Extra Buffalo Sauce",
                Price = (decimal?)0.53,
                CurrencyId = 1,
                DishOptionId = (int)Util.DishOptionType.Values.FakeOptionalSideFourOptionChoices
            };
            return dishOptionsChoice;
        }



        ~FakeOptionalSideFourOptionChoices()
        {
            MyDishOptionsChoices = null;
        }
    }
}
