using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker.DishOptions
{
    public class FakeDishOptions
    {
        public List<DishOption> MyDishOptions;

        public FakeDishOptions()
        {
            InitializeDishOptionList();
        }

        public void InitializeDishOptionList()
        {
            MyDishOptions = new List<DishOption> {
                FirstDishOption(), 
                SecondDishOption(),
                ThirdDishOption(),
                FourthDishOption()
            };
        }


        #region Dish1 Options

        public DishOption FirstDishOption()
        {
            var firstDishOption = new DishOption
            {
                DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideTwelveOptionChoices,
                DishId = 1,
                Title = "Choose a side",
                Instructions ="Required - Choose 1.",
                IsRequired = true
            };
            return firstDishOption;
        }


        public DishOption ThirdDishOption()
        {
            var thirdDishOption = new DishOption
            {
                DishOptionId = (int)Util.DishOptionType.Values.FakeOptionalSideThreeOptionChoices,
                DishId = 1,
                Title = "Pick a side",
                Instructions = "Optional - Choose 1.",
                IsRequired = false
            };
            return thirdDishOption;
        }

        #endregion

        #region Dish3 Options

        public DishOption SecondDishOption()
        {
            var secondDishOption = new DishOption
            {
                DishOptionId = (int)Util.DishOptionType.Values.FakeRequiredSideThreeOptionChoices,
                DishId = 3,
                Title = "Choose a side",
                Instructions = "Required - Choose 1.",
                IsRequired = true
            };
            return secondDishOption;
        }

        #endregion

        #region Dish4 Options

        public DishOption FourthDishOption()
        {
            var fourthDishOption = new DishOption
            {
                DishOptionId = (int)Util.DishOptionType.Values.FakeOptionalSideFourOptionChoices,
                DishId = 4,
                Title = "Pick a side",
                Instructions = "Optional - Choose 1.",
                IsRequired = false
            };
            return fourthDishOption;
        }
        #endregion


        ~FakeDishOptions()
        {
            MyDishOptions = null;
        }
    }
}
