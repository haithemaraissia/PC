using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.Cuisine
{
    public class FakeCuisineTypes
    {
        public List<CuisineType> MyCuisineTypes;

        public FakeCuisineTypes()
        {
            InitializeCuisineTypeList();
        }

        public void InitializeCuisineTypeList()
        {
            MyCuisineTypes = new List<CuisineType> {
                FirstCuisineType(), 
                SecondCuisineType(),
                ThirdCuisineType(),
                FourthCuisineType(),
                FifthCuisineType(),
                SixthCuisineType(),
                SecondCuisineType(),
                SeventhCuisineType()
            };
        }

        public CuisineType FirstCuisineType()
        {
            var firstCuisineType = new CuisineType
            {
                CuisineTypeId = 1,
                CuisineTypeValue = Cuisines.Types.Italian.ToString()
            };
            return firstCuisineType;
        }

        public CuisineType SecondCuisineType()
        {
            var secondCuisineType = new CuisineType
            {
                CuisineTypeId = 2,
                CuisineTypeValue = Cuisines.Types.Mexican.ToString()
            };
            return secondCuisineType;
        }

        public CuisineType ThirdCuisineType()
        {
            var thirdCuisineType = new CuisineType
            {
                CuisineTypeId = 3,
                CuisineTypeValue = Cuisines.Types.Japanese.ToString()
            };
            return thirdCuisineType;
        }

        public CuisineType FourthCuisineType()
        {
            var fourCuisineType = new CuisineType
            {
                CuisineTypeId = 4,
                CuisineTypeValue = Cuisines.Types.Filipino.ToString()
            };
            return fourCuisineType;
        }

        public CuisineType FifthCuisineType()
        {
            var fiveCuisineType = new CuisineType
            {
                CuisineTypeId = 5,
                CuisineTypeValue = Cuisines.Types.Jamaican.ToString()
            };
            return fiveCuisineType;
        }

        public CuisineType SixthCuisineType()
        {
            var sixCuisineType = new CuisineType
            {
                CuisineTypeId = 6,
                CuisineTypeValue = Cuisines.Types.Moroccan.ToString()
            };
            return sixCuisineType;
        }

        public CuisineType SeventhCuisineType()
        {
            var sevenCuisineType = new CuisineType
            {
                CuisineTypeId = 7,
                CuisineTypeValue = Cuisines.Types.Dominican.ToString()
            };
            return sevenCuisineType;
        }
        ~FakeCuisineTypes()
        {
            MyCuisineTypes = null;
        }
    }
}
