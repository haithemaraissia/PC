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
                PromotionTypeValue = DisountType.Values.PercentageOff.ToString()
            };
            return firstPromotionType;
        }

        public PromotionType SecondPromotionType()
        {
            var secondPromotionType = new PromotionType
            {
                PromotionTypeId = (int)DisountType.Values.AmountOff,
                PromotionTypeValue = DisountType.Values.AmountOff.ToString()
            };
            return secondPromotionType;
        }

        public PromotionType ThirdPromotionType()
        {
            var thirdPromotionType = new PromotionType
            {
                PromotionTypeId = (int)DisountType.Values.FixedAmount,
                PromotionTypeValue = DisountType.Values.FixedAmount.ToString()
            };
            return thirdPromotionType;
        }

        ~FakePromotionTypes()
        {
            MyPromotionType = null;
        }
    }
}
