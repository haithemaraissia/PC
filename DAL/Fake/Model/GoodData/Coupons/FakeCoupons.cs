using System.Collections.Generic;
using DAL.Fake.Model.LookUp.Discount;
using Model;

namespace DAL.Fake.Model.GoodData.Coupons
{
    public class FakeCoupons
    {
        public List<Coupon> MyCoupons;

        public FakeCoupons()
        {
            InitializeCouponList();
        }

        public void InitializeCouponList()
        {
            MyCoupons = new List<Coupon> {
                FirstCoupon(), 
                SecondCoupon(),
                ThirdCoupon()
            };
        }

        #region Cooker1Coupon
        
        public Coupon FirstCoupon()
        {
            var firstCoupon = new Coupon
            {
                CouponId = 1,
                CouponTypeId = (int)DisountType.Values.AmountOff,
                CookerId = 1,
                Title = "$5.00 Off Monday-Friday lunch menu",
                Description = "Large Pizza Diavola & Cola",
                Price = (decimal) 5.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Japanese\Asian Fish.jpg"
            };
            return firstCoupon;
        }

        public Coupon SecondCoupon()
        {
            var secondCoupon = new Coupon
            {
                CouponId = 2,
                CouponTypeId = (int)DisountType.Values.PercentageOff,
                CookerId = 1,
                Title = "30 % off Dish of the day: Tagliatelle",
                Description = "Tagliatelle with spinach, mascarpone & Parmesan",
                Price = (decimal)0.30,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Jamaican\Jam.jpg"
            };
            return secondCoupon;
        }

        #endregion

        #region Cooker2Coupon

        public Coupon ThirdCoupon()
        {
            var thirdCoupon = new Coupon
            {
                CouponId = 3,
                CouponTypeId = (int)DisountType.Values.FixedAmount,
                CookerId = 2,
                Title = "$8.00 : Pizza al Salame all Day",
                Description = "Tomato sauce, mozzarella, salami sausage, mixed green and black olives and basil",
                Price = (decimal)8.00,
                CurrencyId = 1,
                Photo = null
            };
            return thirdCoupon;
        }

        #endregion
        ~FakeCoupons()
        {
            MyCoupons = null;
        }
    }
}
