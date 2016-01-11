using System.Collections.Generic;
using DAL.Fake.Model.LookUp.Currency;
using DAL.Fake.Model.LookUp.DishOption;
using Model;

namespace DAL.Fake.Model.GoodData.OrderItemDishes
{
     public class FakeOrderItemDishOptions
    {
       public List<OrderItemDishOption> MyOrderItemDishOptions;

        public FakeOrderItemDishOptions()
        {
            InitializeOrderItemList();
        }

        public void InitializeOrderItemList()
        {
            MyOrderItemDishOptions = new List<OrderItemDishOption> {
                FirstOrderItemDishOption(), SecondOrderItemDishOption(),
                ThirdOrderItemDishOption(),
                FourthOrderItemDishOption()
            };
        }


        #region Client1 First Order

         public OrderItemDishOption FirstOrderItemDishOption()
         {
             //Required
            return  new OrderItemDishOption
            {
                OrderItemDishOptionId = 1,
                DishOptionChoiceId = 3,
                DishOptionChoiceValue = "Cucumber Salad",
                Price = (decimal?)2.09,
                CurrencyId = (int)CurrencyType.Values.Usd,
                DishOptionId = (int)DishOptionType.Values.FakeRequiredSideTwelveOptionChoices,
                Instructions = "no Mayone Please",
                OrderItemId = 1
            };
         }

         public OrderItemDishOption SecondOrderItemDishOption()
         {
            //Optional Side
            return new OrderItemDishOption
            {
                OrderItemDishOptionId = 2,
                DishOptionChoiceId = 17,
                DishOptionChoiceValue = "House Salad",
                Price = null,
                CurrencyId = null,
                DishOptionId = (int)DishOptionType.Values.FakeOptionalSideThreeOptionChoices,
                Instructions = "More Lettuce",
                OrderItemId = 1
            };
         }

         public OrderItemDishOption ThirdOrderItemDishOption()
         {
             //Required Side
            return new OrderItemDishOption
            {
                OrderItemDishOptionId = 3,
                DishOptionChoiceId = 14,
                DishOptionChoiceValue = "New York Strip Steak",
                Price = (decimal?)8.97,
                CurrencyId = 1,
                DishOptionId = (int)DishOptionType.Values.FakeRequiredSideThreeOptionChoices,
                Instructions = "no Mayone Please",
                OrderItemId = 2
            };
         }

        #endregion


        #region Client2 First Order

         public OrderItemDishOption FourthOrderItemDishOption()
         {
            return  new OrderItemDishOption
            {
                OrderItemDishOptionId = 3,
                DishOptionChoiceId = 20,
                DishOptionChoiceValue = "Extra Dressing",
                Price = (decimal?)0.53,
                CurrencyId = (int)CurrencyType.Values.Usd,
                DishOptionId = (int)DishOptionType.Values.FakeOptionalSideFourOptionChoices,
                Instructions = "no Mayone Please",
                OrderItemId = 3
            };
         }
        #endregion


        #region Client3 First Order

        #endregion


         ~FakeOrderItemDishOptions()
        {
            MyOrderItemDishOptions = null;
        }
    }
}
