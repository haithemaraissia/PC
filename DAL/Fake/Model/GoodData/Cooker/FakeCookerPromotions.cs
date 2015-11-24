using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookerPromotions
    {
        public List<CookerPromotion> MyCookerPromotions;

        public FakeCookerPromotions()
        {
            InitializeCookerPromotionList();
        }

        public void InitializeCookerPromotionList()
        {
            MyCookerPromotions = new List<CookerPromotion> {
                FirstCookerPromotion(), 
                ThirdCookerPromotion()
            };
        }

        #region Cooker2 Promotion
        public CookerPromotion FirstCookerPromotion()
        {
            var firstCookerPromotion = new CookerPromotion
            {
                CookerPromotionId = 1,
                CookerId = 2,
                PromotionId = 1
            };
            return firstCookerPromotion;
        }
        #endregion

        #region Cooker3 Promotion

        public CookerPromotion SecondCookerPromotion()
        {
            var firstCookerPromotion = new CookerPromotion
            {
                CookerPromotionId = 2,
                CookerId = 3,
                PromotionId = 2
            };
            return firstCookerPromotion;
        }

        public CookerPromotion ThirdCookerPromotion()
        {
            var thirdCookerPromotion = new CookerPromotion
            {
                CookerPromotionId = 3,
                CookerId = 3,
                PromotionId = 3
            };
            return thirdCookerPromotion;
        }

        #endregion
        ~FakeCookerPromotions()
        {
            MyCookerPromotions = null;
        }
    }
}
