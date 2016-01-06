namespace DAL.Fake.Model.Util
{
    public class OrderStatus
    {
        public enum Values
        {

            #region Client
            Submitted = 1,
            #endregion

            #region Cooker
            Incoming = 5,

            #endregion

            #region Common
            InProgress = 2,
            Done = 3,
            History = 4,
            #endregion

        }
    }
}