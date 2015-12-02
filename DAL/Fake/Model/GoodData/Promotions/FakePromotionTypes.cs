using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.Promotion
{
    public class FakePromotionTypes
    {
        public List<PromotionType> MyPromotionType;

        public FakePromotionTypes()
        {
            InitializePromotionTypeList();
        }

        public void InitializePromotionTypeList()
        {
            MyPromotionType = new List<PromotionType> {
                FirstPromotionType(), 
                SecondPromotionType(),
                ThirdPromotionType()
            };
        }

        public PromotionType FirstPromotionType()
        {
            var firstPromotionType = new PromotionType
            {
                PromotionTypeId = (int)DisountType.Values.PercentageOff,
                PromotionTypeValue = "Percentage Off"
            };
            return firstPromotionType;
        }

        public PromotionType SecondPromotionType()
        {
            var secondPromotionType = new PromotionType
            {
                PromotionTypeId = (int)DisountType.Values.AmountOff,
                PromotionTypeValue = "Amount Off"
            };
            return secondPromotionType;
        }

        public PromotionType ThirdPromotionType()
        {
            var thirdPromotionType = new PromotionType
            {
                PromotionTypeId = (int)DisountType.Values.FixedAmount,
                PromotionTypeValue = "Fixed Amount"
            };
            return thirdPromotionType;
        }

        ~FakePromotionTypes()
        {
            MyPromotionType = null;
        }
    }
}
