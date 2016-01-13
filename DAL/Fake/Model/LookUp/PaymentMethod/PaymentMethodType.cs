namespace DAL.Fake.Model.LookUp.PaymentMethod
{
    public class PaymentMethodType
    {
        public enum Values
        {
            NotSet = 0,
            CardOnLine = 1,
            Cash = 2,
            CardToCounter = 3
        }
    }
}