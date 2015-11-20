using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
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
                PaymentMethodId = 1,
                PaymentMethodValue = "Card on Line"
            };
            return firstPaymentMethod;
        }

        public PaymentMethod SecondPaymentMethod()
        {
            var secondPaymentMethod = new PaymentMethod
            {
                PaymentMethodId = 2,
                PaymentMethodValue = "Cash"
            };
            return secondPaymentMethod;
        }

        public PaymentMethod ThirdPaymentMethod()
        {
            var thirdPaymentMethod = new PaymentMethod
            {
                PaymentMethodId = 1,
                PaymentMethodValue = "Card to the counter/rider"
            };
            return thirdPaymentMethod;
        }

        ~FakePaymentMethods()
        {
            MyPaymentMethods = null;
        }
    }
}
