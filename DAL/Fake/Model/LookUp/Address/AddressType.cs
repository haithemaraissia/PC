namespace DAL.Fake.Model.LookUp.Address
{
    public class AddressType
    {
        public enum Values
        {
            #region Client
            #endregion

            Home = 1,
            Work = 2,
            Other = 3,

            #region Cooker
            Restaurant = 4
            #endregion

        }
    }
}