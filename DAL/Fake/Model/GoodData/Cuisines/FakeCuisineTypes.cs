using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cuisines
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
                CuisineTypeId = (int)LookUp.Cuisine.Cuisines.Types.Italian,
                CuisineTypeValue = LookUp.Cuisine.Cuisines.Types.Italian.ToString()
            };
            return firstCuisineType;
        }

        public CuisineType SecondCuisineType()
        {
            var secondCuisineType = new CuisineType
            {
                CuisineTypeId =  (int)LookUp.Cuisine.Cuisines.Types.Mexican,
                CuisineTypeValue = LookUp.Cuisine.Cuisines.Types.Mexican.ToString()
            };
            return secondCuisineType;
        }

        public CuisineType ThirdCuisineType()
        {
            var thirdCuisineType = new CuisineType
            {
                CuisineTypeId =  (int)LookUp.Cuisine.Cuisines.Types.Japanese,
                CuisineTypeValue = LookUp.Cuisine.Cuisines.Types.Japanese.ToString()
            };
            return thirdCuisineType;
        }

        public CuisineType FourthCuisineType()
        {
            var fourCuisineType = new CuisineType
            {
                CuisineTypeId =  (int)LookUp.Cuisine.Cuisines.Types.Filipino,
                CuisineTypeValue = LookUp.Cuisine.Cuisines.Types.Filipino.ToString()
            };
            return fourCuisineType;
        }

        public CuisineType FifthCuisineType()
        {
            var fiveCuisineType = new CuisineType
            {
                CuisineTypeId = (int)LookUp.Cuisine.Cuisines.Types.Jamaican,
                CuisineTypeValue = LookUp.Cuisine.Cuisines.Types.Jamaican.ToString()
            };
            return fiveCuisineType;
        }

        public CuisineType SixthCuisineType()
        {
            var sixCuisineType = new CuisineType
            {
                CuisineTypeId = (int)LookUp.Cuisine.Cuisines.Types.Moroccan,
                CuisineTypeValue = LookUp.Cuisine.Cuisines.Types.Moroccan.ToString()
            };
            return sixCuisineType;
        }

        public CuisineType SeventhCuisineType()
        {
            var sevenCuisineType = new CuisineType
            {
                CuisineTypeId = (int)LookUp.Cuisine.Cuisines.Types.Dominican,
                CuisineTypeValue = LookUp.Cuisine.Cuisines.Types.Dominican.ToString()
            };
            return sevenCuisineType;
        }
        ~FakeCuisineTypes()
        {
            MyCuisineTypes = null;
        }
    }
}
