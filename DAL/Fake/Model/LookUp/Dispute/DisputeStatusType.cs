namespace DAL.Fake.Model.LookUp.Dispute
{
    public class DisputeStatus
    {
        public enum Values
        {
            Opened = 1,
            Processing = 2,
            Escalated = 3,
            Resolved= 4,
            UnResolved = 5
        }
    }
}