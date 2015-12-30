using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.Promotions
{
    public class FakePromotions
    {
        public List<global::Model.Promotion> MyPromotions;

        public FakePromotions()
        {
            InitializePromotionList();
        }

        public void InitializePromotionList()
        {
            MyPromotions = new List<global::Model.Promotion> {
                FirstPromotion(), 
                SecondPromotion(),
                ThirdPromotion()
            };
        }

        public global::Model.Promotion FirstPromotion()
        {
            var firstPromotion = new global::Model.Promotion
            {
                PromotionId = 1,
                PromotionTypeId = (int)DisountType.Values.PercentageOff,
                Title = "20% Off Monday-Friday lunch menu",
                Description = "Large Pizza Diavola & Cola",
                Price = (decimal)0.20,
                CurrencyId = 1,
                Photo = null,
                ServingId = 5
            };
            return firstPromotion;
        }

        public global::Model.Promotion SecondPromotion()
        {
            var secondPromotion = new global::Model.Promotion
            {
                PromotionId = 2,
                PromotionTypeId = (int)DisountType.Values.AmountOff,
                Title = "$5.00 Off Dish of the day: Tagliatelle",
                Description = "Tagliatelle with spinach, mascarpone & Parmesan",
                Price = (decimal)5.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\greek-salad.jpg",
                ServingId = 6
            };
            return secondPromotion;
        }

        public global::Model.Promotion ThirdPromotion()
        {
            var thirdPromotion = new global::Model.Promotion
            {
                PromotionId = 3,
                PromotionTypeId = (int)DisountType.Values.FixedAmount,
                Title = "$8.00 Any dish Monday-Friday",
                Description = "Any item in the menu: Monday-Friday",
                Price = (decimal)8.00,
                CurrencyId = 1,
                Photo = "",
                ServingId = 4
            };
            return thirdPromotion;
        }

        ~FakePromotions()
        {
            MyPromotions = null;
        }
    }
}
