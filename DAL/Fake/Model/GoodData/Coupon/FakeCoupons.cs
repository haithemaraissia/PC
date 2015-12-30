using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Coupon
{
    public class FakeCoupons
    {
        public List<global::Model.Coupon> MyCoupons;

        public FakeCoupons()
        {
            InitializeCouponList();
        }

        public void InitializeCouponList()
        {
            MyCoupons = new List<global::Model.Coupon> {
                FirstCoupon(), 
                SecondCoupon(),
                ThirdCoupon()
            };
        }

        #region Cooker1Coupon
        
        public global::Model.Coupon FirstCoupon()
        {
            var firstCoupon = new global::Model.Coupon
            {
                CouponId = 1,
                CookerId = 1,
                Title = "Monday-Friday lunch menu",
                Description = "Large Pizza Diavola & Cola",
                Price = (decimal) 9.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Japanese\Asian Fish.jpg"
            };
            return firstCoupon;
        }

        public global::Model.Coupon SecondCoupon()
        {
            var secondCoupon = new global::Model.Coupon
            {
                CouponId = 2,
                CookerId = 1,
                Title = "Dish of the day: Tagliatelle",
                Description = "Tagliatelle with spinach, mascarpone & Parmesan",
                Price = (decimal)6.50,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Jamaican\Jam.jpg"
            };
            return secondCoupon;
        }

        #endregion

        #region Cooker2Coupon

        public global::Model.Coupon ThirdCoupon()
        {
            var thirdCoupon = new global::Model.Coupon
            {
                CouponId = 3,
                CookerId = 2,
                Title = "Pizza al Salame",
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
