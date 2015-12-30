using System.Collections.Generic;
using DAL.Fake.Model.Util;
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
                ServingMeasurementId = (int)ServingMeasurementType.Values.TwoCupContainer,
                ServingMeasurementValue = ServingMeasurementType.Values.TwoCupContainer.ToString()
            };
            return firstServingMeasurement;
        }

        public ServingMeasurement SecondServingMeasurement()
        {
            var secondServingMeasurement = new ServingMeasurement
            {
                ServingMeasurementId = (int)ServingMeasurementType.Values.FourCupContainer,
                ServingMeasurementValue = ServingMeasurementType.Values.FourCupContainer.ToString()
            };
            return secondServingMeasurement;
        }

        public ServingMeasurement ThirdServingMeasurement()
        {
            var thirdServingMeasurement = new ServingMeasurement
            {
                ServingMeasurementId = (int)ServingMeasurementType.Values.SevenCupContainer,
                ServingMeasurementValue = ServingMeasurementType.Values.SevenCupContainer.ToString()
            };
            return thirdServingMeasurement;
        }

        #endregion


        #region Bowl

        public ServingMeasurement FourthServingMeasurement()
        {
            var fourthServingMeasurement = new ServingMeasurement
            {
                ServingMeasurementId = (int)ServingMeasurementType.Values.SmallBowl12Oz,
                ServingMeasurementValue = ServingMeasurementType.Values.SmallBowl12Oz.ToString()
            };
            return fourthServingMeasurement;
        }

        public ServingMeasurement FifthServingMeasurement()
        {
            var fifthServingMeasurement = new ServingMeasurement
            {
                ServingMeasurementId = (int)ServingMeasurementType.Values.MediumBowl14Oz,
                ServingMeasurementValue = ServingMeasurementType.Values.MediumBowl14Oz.ToString()
            };
            return fifthServingMeasurement;
        }

        public ServingMeasurement SixthServingMeasurement()
        {
            var sixthServingMeasurement = new ServingMeasurement
            {
                ServingMeasurementId = (int)ServingMeasurementType.Values.BigBowl28Oz,
                ServingMeasurementValue = ServingMeasurementType.Values.BigBowl28Oz.ToString()
            };
            return sixthServingMeasurement;
        }

        #endregion


        #region Plate

        public ServingMeasurement SeventhServingMeasurement()
        {
            var seventhServingMeasurement = new ServingMeasurement
            {
                ServingMeasurementId = (int)ServingMeasurementType.Values.BreadPlate6Inches,
                ServingMeasurementValue = ServingMeasurementType.Values.BreadPlate6Inches.ToString()
            };
            return seventhServingMeasurement;
        }

        public ServingMeasurement EighthServingMeasurement()
        {
            var eighthServingMeasurement = new ServingMeasurement
            {
                ServingMeasurementId = (int)ServingMeasurementType.Values.LunchPlate9Inches,
                ServingMeasurementValue = ServingMeasurementType.Values.LunchPlate9Inches.ToString()
            };
            return eighthServingMeasurement;
        }

        public ServingMeasurement NinethServingMeasurement()
        {
            var ninethServingMeasurement = new ServingMeasurement
            {
                ServingMeasurementId = (int)ServingMeasurementType.Values.DinnerPlate12Inches,
                ServingMeasurementValue = ServingMeasurementType.Values.DinnerPlate12Inches.ToString()
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
