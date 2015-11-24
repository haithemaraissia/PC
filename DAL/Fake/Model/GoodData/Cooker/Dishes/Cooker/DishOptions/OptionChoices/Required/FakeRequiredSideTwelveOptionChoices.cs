using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker.DishOptions.OptionChoices.Required
{
    public class FakeRequiredSideOptionChoices
    {
        public List<DishOptionsChoice> MyDishOptionsChoices;

        public FakeRequiredSideOptionChoices()
        {
            InitializeDishOptionsChoiceList();
        }

        public void InitializeDishOptionsChoiceList()
        {
            MyDishOptionsChoices = new List<DishOptionsChoice> {
                FirstDishOptionsChoice(), 
                SecondDishOptionsChoice(),
                ThirdDishOptionsChoice(),
                FourthDishOptionsChoice(),

                FifthDishOptionsChoice(),
                SixthDishOptionsChoice(),
                SeventhDishOptionsChoice(),
                EightDishOptionsChoice(),

                NinethDishOptionsChoice(),
                TenthDishOptionsChoice(),
                EleventhDishOptionsChoice(),
                TwelveDishOptionsChoice()
            };
        }

        public DishOptionsChoice FirstDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 1,
                DishOptionChoiceValue = "Hand-Cut French Fries",
                Price = null,
                CurrencyId = null,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice SecondDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 2,
                DishOptionChoiceValue = "Fresh Fruit",
                Price = null,
                CurrencyId = null,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice ThirdDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 3,
                DishOptionChoiceValue = "Cucumber Salad",
                Price = (decimal?) 2.09,
                CurrencyId = 1,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice FourthDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 4,
                DishOptionChoiceValue = "Turbo Tots",
                Price = (decimal?)3.14,
                CurrencyId = 1,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice FifthDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 5,
                DishOptionChoiceValue = "Potato Chips",
                Price = null,
                CurrencyId = null,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice SixthDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 6,
                DishOptionChoiceValue = "Cottage Cheese",
                Price = null,
                CurrencyId = null,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice SeventhDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 7,
                DishOptionChoiceValue = "Onion Rings",
                Price = (decimal?)2.09,
                CurrencyId = 1,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice EightDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 8,
                DishOptionChoiceValue = "Mac and Cheese",
                Price = (decimal?)3.14,
                CurrencyId = 1,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice NinethDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 9,
                DishOptionChoiceValue = "Seasonal Vegetables",
                Price = null,
                CurrencyId = null,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice TenthDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 10,
                DishOptionChoiceValue = "Cole Slaw",
                Price = null,
                CurrencyId = null,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice EleventhDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 11,
                DishOptionChoiceValue = "Sweet Potato Tots",
                Price = (decimal?)2.09,
                CurrencyId = 1,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }

        public DishOptionsChoice TwelveDishOptionsChoice()
        {
            var dishOptionsChoice = new DishOptionsChoice
            {
                DishOptionChoiceId = 12,
                DishOptionChoiceValue = "Vegetables",
                Price = (decimal?)2.09,
                CurrencyId = 1,
               DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices
            };
            return dishOptionsChoice;
        }


        ~FakeRequiredSideOptionChoices()
        {
            MyDishOptionsChoices = null;
        }
    }
}
