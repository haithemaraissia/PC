using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookerPaymentMethods
    {
        public List<CookerPaymentMethod> MyCookerPaymentMethods;

        public FakeCookerPaymentMethods()
        {
            InitializeCookerPaymentMethodList();
        }

        public void InitializeCookerPaymentMethodList()
        {
            MyCookerPaymentMethods = new List<CookerPaymentMethod> {
                FirstCookerPaymentMethod(), 
                SecondCookerPaymentMethod(),
                ThirdCookerPaymentMethod(),
                FourthCookerPaymentMethod(),
                FifthCookerPaymentMethod(),
                SixthCookerPaymentMethod()
            };
        }

        #region Cooker1

        public CookerPaymentMethod FirstCookerPaymentMethod()
        {
            var firstCookerPaymentMethod = new CookerPaymentMethod
            {
                CookerPaymentMethodId = 1,
                CookerId = 1,
                PaymentMethodId = 1
            };
            return firstCookerPaymentMethod;
        }

        public CookerPaymentMethod SecondCookerPaymentMethod()
        {
            var secondCookerPaymentMethod = new CookerPaymentMethod
            {
                CookerPaymentMethodId = 2,
                CookerId = 1,
                PaymentMethodId = 2
            };
            return secondCookerPaymentMethod;
        }

        public CookerPaymentMethod ThirdCookerPaymentMethod()
        {
            var thirdCookerPaymentMethod = new CookerPaymentMethod
            {
                CookerPaymentMethodId = 3,
                CookerId = 1,
                PaymentMethodId = 3
            };
            return thirdCookerPaymentMethod;
        }

        #endregion

        #region Cooker2

        public CookerPaymentMethod FourthCookerPaymentMethod()
        {
            var fourthCookerPaymentMethod = new CookerPaymentMethod
            {
                CookerPaymentMethodId = 4,
                CookerId = 2,
                PaymentMethodId = 1
            };
            return fourthCookerPaymentMethod;
        }

        public CookerPaymentMethod FifthCookerPaymentMethod()
        {
            var fifthCookerPaymentMethod = new CookerPaymentMethod
            {
                CookerPaymentMethodId = 5,
                CookerId = 2,
                PaymentMethodId = 2
            };
            return fifthCookerPaymentMethod;
        }

        #endregion

        #region Cooker3

        public CookerPaymentMethod SixthCookerPaymentMethod()
        {
            var sixthCookerPaymentMethod = new CookerPaymentMethod
            {
                CookerPaymentMethodId = 6,
                CookerId = 3,
                PaymentMethodId = 3
            };
            return sixthCookerPaymentMethod;
        }

        #endregion

        ~FakeCookerPaymentMethods()
        {
            MyCookerPaymentMethods = null;
        }
    }
}
