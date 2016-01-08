using System.Collections.Generic;
using DAL.Fake.Model.LookUp.PaymentMethod;
using Model;

namespace DAL.Fake.Model.GoodData.PaymentMethods
{
    public class FakePaymentMethods
    {
        public List<PaymentMethod> MyPaymentMethods;

        public FakePaymentMethods()
        {
            InitializePaymentMethodList();
        }

        public void InitializePaymentMethodList()
        {
            MyPaymentMethods = new List<PaymentMethod> {
                FirstPaymentMethod(), 
                SecondPaymentMethod(),
                ThirdPaymentMethod()
            };
        }

        public PaymentMethod FirstPaymentMethod()
        {
            var firstPaymentMethod = new PaymentMethod
            {
                PaymentMethodId = (int)PaymentMethodType.Values.CardOnLine,
                PaymentMethodValue = PaymentMethodType.Values.CardOnLine.ToString()
            };
            return firstPaymentMethod;
        }

        public PaymentMethod SecondPaymentMethod()
        {
            var secondPaymentMethod = new PaymentMethod
            {
                PaymentMethodId = (int)PaymentMethodType.Values.Cash,
                PaymentMethodValue = PaymentMethodType.Values.Cash.ToString()
            };
            return secondPaymentMethod;
        }

        public PaymentMethod ThirdPaymentMethod()
        {
            var thirdPaymentMethod = new PaymentMethod
            {
                PaymentMethodId = (int)PaymentMethodType.Values.CardToCounter,
                PaymentMethodValue = PaymentMethodType.Values.CardToCounter.ToString()
            };
            return thirdPaymentMethod;
        }

        ~FakePaymentMethods()
        {
            MyPaymentMethods = null;
        }
    }
}
