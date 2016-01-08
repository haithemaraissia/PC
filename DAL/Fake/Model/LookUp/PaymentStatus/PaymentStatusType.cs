namespace DAL.Fake.Model.LookUp.PaymentStatus
{
    public class PaymentStatusType
    {
        public enum Values
        {
            CanceledReversal = 1,
            Completed = 2,
            Created = 3,
            Denied = 4,
            Expired = 5,
            Failed = 6,
            Pending = 7,
            Refunded = 8,
            Reversed = 9,
            Processed = 10,
            Voided =11
        }
    }
}