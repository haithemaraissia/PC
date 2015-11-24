using System.Collections.Generic;
using DAL.Fake.Model.Util;

namespace DAL.Fake.Model.GoodData.User
{
    public class FakeUsers
    {
        public List<global::Model.User> MyUsers;

        public FakeUsers()
        {
            InitializeUserList();
        }

        public void InitializeUserList()
        {
            MyUsers = new List<global::Model.User> {
                FirstUser(), 
                SecondUser(),
                ThirdUser(),
                FourthUser(),
                FifthUser(),
                SixthUser()
            };
        }

        #region Cooker

        //Cooker 1
        public global::Model.User FirstUser()
        {
            var firstUser = new global::Model.User
            {
                UserId = 1,
                FirstName = "Jon",
                LastName = "Smith",
                EmailAddress= "johnsmith@yahoo.com",
                UserTypeId = (int)UserTypes.Values.Cooker,
                Photo = @"C:\Users\haraissia\AndroidStudioProjects\android-topeka\app\build\intermediates\res\debug\drawable-xxxhdpi\avatar_5_raster.png",
                Bio = "Hi, my name is Jon Smith. A highly motivated and capable professional cook with a real passion for preparing popular, healthy and nutritious meals.",
                CountryId= 1,
                RegionId =1,
                CityId = 1,
                ZipCode = "66216",
                Address = "6805 main Street",
                AddressTypeId = 1,
                PhoneNumber = "9134513214"
            };
            return firstUser;
        }

        //Cooker 2
        public global::Model.User SecondUser()
        {
            var secondUser = new global::Model.User
            {
                UserId = 2,
                FirstName = "Mike",
                LastName = "Douglas",
                EmailAddress= "mikeDouglas@yahoo.com",
                UserTypeId = (int)UserTypes.Values.Cooker,
                Photo = @"C:\Users\haraissia\AndroidStudioProjects\android-topeka\app\build\intermediates\res\debug\drawable-xxxhdpi\avatar_1_raster.png",
                Bio= "This is Mike's Bio.I enjoy cooking and providing services to my happy customers",
                CountryId= 1,
                RegionId =1,
                CityId = 1,
                ZipCode ="66206",
                Address = "11201 South West Boulevard",
                AddressTypeId = 2,
                PhoneNumber = "7561023214"
            };
            return secondUser;
        }        

        //Cooker 3
        public global::Model.User FifthUser()
        {
            var fifthUser = new global::Model.User
            {
                UserId = 5,
                FirstName = "Sara",
                LastName = "Youssef",
                EmailAddress = "sarayoussef@yahoo.com",
                UserTypeId = (int)UserTypes.Values.Cooker,
                Photo = @"C:\Users\haraissia\AndroidStudioProjects\android-topeka\app\build\intermediates\res\debug\drawable-xxxhdpi\avatar_9_raster.png",
                Bio = "This is Sara's Bio.I enjoy making food and cookies to my grand childrens",
                CountryId = 1,
                RegionId = 1,
                CityId = 1,
                ZipCode = "66206",
                Address = "601 Block Bob",
                Apt_suite = "301",
                AddressTypeId = 1,
                PhoneNumber = "8167561010"
            };
            return fifthUser;
        }

        #endregion

        #region Client

        //Client 1
        public global::Model.User ThirdUser()
        {
            var thirdUser = new global::Model.User
            {
                UserId = 3,
                FirstName = "Robert",
                LastName = "Lone",
                EmailAddress= "robertlone@yahoo.com",
                UserTypeId = (int)UserTypes.Values.Client,
                Photo = @"C:\Users\haraissia\AndroidStudioProjects\android-topeka\app\build\intermediates\res\debug\drawable-xxxhdpi\avatar_2_raster.png",
                Bio="I love good and healthy food",
                CountryId= 1,
                RegionId =1,
                CityId = 1,
                ZipCode ="66216",
                Address = "4805 main Street",
                Apt_suite = "601",
                AddressTypeId = 2,
                PhoneNumber = "8167561010"
            };
            return thirdUser;
        }

        //Client 2
        public global::Model.User FourthUser()
        {
            var fourthUser = new global::Model.User
            {
                UserId = 4,
                FirstName = "Robert",
                LastName = "Lone",
                EmailAddress = "robertlone@yahoo.com",
                UserTypeId = (int)UserTypes.Values.Client,
                Photo = @"C:\Users\haraissia\AndroidStudioProjects\android-topeka\app\build\intermediates\res\debug\drawable-xxxhdpi\avatar_2_raster.png",
                Bio = "I love good and healthy food too",
                CountryId = 1,
                RegionId = 1,
                CityId = 1,
                ZipCode = "66216",
                Address = "6102 Plumb Road",
                AddressTypeId = 1,
                PhoneNumber = "9134060298"
            };
            return fourthUser;
        }

        //Client 3
        public global::Model.User SixthUser()
        {
            var sixthUser = new global::Model.User
            {
                UserId = 6,
                FirstName = "Robert",
                LastName = "Lone",
                EmailAddress = "robertlone@yahoo.com",
                UserTypeId = (int)UserTypes.Values.Client,
                Photo = @"C:\Users\haraissia\AndroidStudioProjects\android-topeka\app\build\intermediates\res\debug\drawable-xxxhdpi\avatar_2_raster.png",
                Bio = "I eat food",
                CountryId = 1,
                RegionId = 1,
                CityId = 1,
                ZipCode = "66216",
                Address = "4804 Quivira Road ",
                Apt_suite = "302",
                AddressTypeId = 3
            };
            return sixthUser;
        }

       #endregion

        ~FakeUsers()
        {
            MyUsers = null;
        }
    }
}
