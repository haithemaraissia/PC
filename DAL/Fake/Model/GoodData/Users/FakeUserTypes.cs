using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.User
{
    public class FakeUserTypes
    {
        public List<UserType> MyUserTypes;

        public FakeUserTypes()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MyUserTypes = new List<UserType> {
                FirstUserType(), 
                SecondUserType(),
            };
        }

        public UserType FirstUserType()
        {
            var firstUserType = new UserType
            {
                UserTypeId = 1,
                UserTypeValue = UserTypes.Values.Cooker.ToString()
            };
            return firstUserType;
        }

        public UserType SecondUserType()
        {
            var secondUserType = new UserType
            {
                UserTypeId = 2,
                UserTypeValue = UserTypes.Values.Client.ToString()
            };
            return secondUserType;
        }

        ~FakeUserTypes()
        {
            MyUserTypes = null;
        }
    }
}
