using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookerCuisines
    {
        public List<CookerCuisine> MyCookerCuisines;

        public FakeCookerCuisines()
        {
            InitializeCookerCuisineList();
        }

        public void InitializeCookerCuisineList()
        {
            MyCookerCuisines = new List<CookerCuisine> {
                FirstCookerCuisine(), 
                SecondCookerCuisine(),
                ThirdCookerCuisine(),
                FourthCookerCuisine(),
                FifthCookerCuisine(),
                SixthCookerCuisine(),
                SeventhCookerCuisine()
            };
        }

        #region Cooker1

        #region ItalienCuisine
        
        public CookerCuisine FirstCookerCuisine()
        {
            var firstCookerCuisine = new CookerCuisine
            {
                CuisineTypeId = 1,
                CookerId = 1,
                CookerCuisineId = (int)Cuisines.Types.Italian
            };
            return firstCookerCuisine;
        }
        #endregion

        #region MexicanCuisine
        public CookerCuisine SecondCookerCuisine()
        {
            var secondCookerCuisine = new CookerCuisine
            {
                CuisineTypeId = 2,
                CookerId = 1,
                CookerCuisineId = (int)Cuisines.Types.Mexican
            };
            return secondCookerCuisine;
        }
        #endregion

        #endregion

        #region Cooker2

        #region JapaneseCuisine

        public CookerCuisine ThirdCookerCuisine()
        {
            var thirdCookerCuisine = new CookerCuisine
            {
                CuisineTypeId = 3,
                CookerId = 2,
                CookerCuisineId = (int)Cuisines.Types.Japanese
            };
            return thirdCookerCuisine;
        }
        #endregion

        #region FilipinoCuisine
        public CookerCuisine FourthCookerCuisine()
        {
            var fourthCookerCuisine = new CookerCuisine
            {
                CuisineTypeId = 4,
                CookerId = 2,
                CookerCuisineId = (int)Cuisines.Types.Filipino
            };
            return fourthCookerCuisine;
        }
        #endregion

        #region JamaicanCuisine

        public CookerCuisine FifthCookerCuisine()
        {
            var fifthCookerCuisine = new CookerCuisine
            {
                CuisineTypeId = 5,
                CookerId = 2,
                CookerCuisineId = (int)Cuisines.Types.Jamaican
            };
            return fifthCookerCuisine;
        }
        #endregion

        #region MorrocanCuisine

        public CookerCuisine SixthCookerCuisine()
        {
            var sixthCookerCuisine = new CookerCuisine
            {
                CuisineTypeId = 6,
                CookerId = 2,
                CookerCuisineId = (int)Cuisines.Types.Moroccan
            };
            return sixthCookerCuisine;
        }
        #endregion
        #endregion

        #region Cooker3

        #region DominicanCuisine

        public CookerCuisine SeventhCookerCuisine()
        {
            var seventhCookerCuisine = new CookerCuisine
            {
                CuisineTypeId = 7,
                CookerId = 3,
                CookerCuisineId = (int)Cuisines.Types.Dominican
            };
            return seventhCookerCuisine;
        }
        #endregion

        #endregion

        ~FakeCookerCuisines()
        {
            MyCookerCuisines = null;
        }
    }
}
