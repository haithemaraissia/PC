using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.Coupon
{
    public class FakeCouponTypes
    {
        public List<CouponType> MyCouponType;

        public FakeCouponTypes()
        {
            InitializeCouponTypeList();
        }

        public void InitializeCouponTypeList()
        {
            MyCouponType = new List<CouponType> {
                FirstCouponType(), 
                SecondCouponType(),
                ThirdCouponType()
            };
        }

        public CouponType FirstCouponType()
        {
            var firstCouponType = new CouponType
            {
                CouponTypeId = (int)DisountType.Values.PercentageOff,
                CouponTypeValue = DisountType.Values.PercentageOff.ToString()
            };
            return firstCouponType;
        }

        public CouponType SecondCouponType()
        {
            var secondCouponType = new CouponType
            {
                CouponTypeId = (int)DisountType.Values.AmountOff,
                CouponTypeValue = DisountType.Values.AmountOff.ToString()
            };
            return secondCouponType;
        }

        public CouponType ThirdCouponType()
        {
            var thirdCouponType = new CouponType
            {
                CouponTypeId = (int)DisountType.Values.FixedAmount,
                CouponTypeValue = DisountType.Values.FixedAmount.ToString()
            };
            return thirdCouponType;
        }

        ~FakeCouponTypes()
        {
            MyCouponType = null;
        }
    }
}
