using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookerCoupon
    {
        public List<CookerCoupon> MyCookerCoupons;

        public FakeCookerCoupon()
        {
            InitializeCookerCouponList();
        }

        public void InitializeCookerCouponList()
        {
            MyCookerCoupons = new List<CookerCoupon> {
                FirstCookerCoupon(), 
                SecondCookerCoupon(),
                ThirdCookerCoupon()
            };
        }

        public CookerCoupon FirstCookerCoupon()
        {
            var firstCookerCoupon = new CookerCoupon
            {
                CookerCouponId = 1,
                CookerId = 1,
                CouponId = 1,
                CouponDate = DateTime.Today.Date
            };
            return firstCookerCoupon;
        }

        public CookerCoupon SecondCookerCoupon()
        {
            var secondCookerCoupon = new CookerCoupon
            {
                CookerCouponId = 2,
                CookerId = 1,
                CouponId = 2,
                CouponDate = DateTime.Today.Date
            };
            return secondCookerCoupon;
        }

        public CookerCoupon ThirdCookerCoupon()
        {
            var thirdCookerCoupon = new CookerCoupon
            {
                CookerCouponId = 3,
                CookerId = 2,
                CouponId = 3,
                CouponDate = DateTime.Today.Date
            };
            return thirdCookerCoupon;
        }

        ~FakeCookerCoupon()
        {
            MyCookerCoupons = null;
        }
    }
}
