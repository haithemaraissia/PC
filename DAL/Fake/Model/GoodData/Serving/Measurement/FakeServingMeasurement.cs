using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Serving.Measurement
{
    public class FakeServingMeasurement
    {
        public List<ServingMeasurement> MyServingMeasurement;

        public FakeServingMeasurement()
        {
            InitializeOrderList();
        }

        public void InitializeOrderList()
        {
            MyServingMeasurement = new List<ServingMeasurement> {
                FirstServingMeasurement(), 
                SecondServingMeasurement(),
                ThirdServingMeasurement(),
                FourthServingMeasurement(),
                FifthServingMeasurement(),
                SixthServingMeasurement(),
                SeventhServingMeasurement(),
                EighthServingMeasurement(),
                NinethServingMeasurement()
            };
        }


        #region Cup Container

        public ServingMeasurement FirstServingMeasurement()
        {
            var firstServingMeasurement = new ServingMeasurement
            {
                ServingId = 1,
                ServingValue = "2 Cup Container"
            };
            return firstServingMeasurement;
        }

        public ServingMeasurement SecondServingMeasurement()
        {
            var secondServingMeasurement = new ServingMeasurement
            {
                ServingId = 2,
                ServingValue = "4 Cup Container"
            };
            return secondServingMeasurement;
        }

        public ServingMeasurement ThirdServingMeasurement()
        {
            var thirdServingMeasurement = new ServingMeasurement
            {
                ServingId = 3,
                ServingValue = "7 Cup Container"
            };
            return thirdServingMeasurement;
        }

        #endregion


        #region Bowl

        public ServingMeasurement FourthServingMeasurement()
        {
            var fourthServingMeasurement = new ServingMeasurement
            {
                ServingId = 4,
                ServingValue = "Small Bowl 12oz"
            };
            return fourthServingMeasurement;
        }

        public ServingMeasurement FifthServingMeasurement()
        {
            var fifthServingMeasurement = new ServingMeasurement
            {
                ServingId = 5,
                ServingValue = "Medium Bowl 14 oz"
            };
            return fifthServingMeasurement;
        }

        public ServingMeasurement SixthServingMeasurement()
        {
            var sixthServingMeasurement = new ServingMeasurement
            {
                ServingId = 6,
                ServingValue = "Big Bowl 28 oz"
            };
            return sixthServingMeasurement;
        }

        #endregion


        #region Plate

        public ServingMeasurement SeventhServingMeasurement()
        {
            var seventhServingMeasurement = new ServingMeasurement
            {
                ServingId = 7,
                ServingValue = "Bread Plate ( 6 inches)"
            };
            return seventhServingMeasurement;
        }

        public ServingMeasurement EighthServingMeasurement()
        {
            var eighthServingMeasurement = new ServingMeasurement
            {
                ServingId = 8,
                ServingValue = "Lunch Plate ( 9 inches)"
            };
            return eighthServingMeasurement;
        }

        public ServingMeasurement NinethServingMeasurement()
        {
            var ninethServingMeasurement = new ServingMeasurement
            {
                ServingId = 9,
                ServingValue = "Dinner Plates ( 12 inches)"
            };
            return ninethServingMeasurement;
        }

        #endregion
        ~FakeServingMeasurement()
        {
            MyServingMeasurement = null;
        }
    }
}
