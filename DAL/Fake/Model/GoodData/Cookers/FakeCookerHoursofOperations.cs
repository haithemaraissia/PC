using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookerHoursofOperation
    {
        public List<CookerHoursofOperation> MyCookerHoursofOperations;

        public FakeCookerHoursofOperation()
        {
            InitializeCookerHoursofOperationList();
        }

        public void InitializeCookerHoursofOperationList()
        {
            MyCookerHoursofOperations = new List<CookerHoursofOperation> {
                FirstCookerHoursofOperation(), 
                SecondCookerHoursofOperation(),
                ThirdCookerHoursofOperation()
            };
        }

        public CookerHoursofOperation FirstCookerHoursofOperation()
        {
            var firstCookerHoursofOperation = new CookerHoursofOperation
            {
                CookerId = 1,
                OpeningHours = new TimeSpan(0, 6, 0, 0),
                OpeningDays = "Monday - Thursday",
                ClosingHours = new TimeSpan(0, 18, 0, 0),

                DeliveryHours = new TimeSpan(0, 6, 0, 0),
                DeliveryDays = "Wednesday",
                ClosingDeliveryHours = new TimeSpan(0, 18, 0, 0),

                PickUpHours = new TimeSpan(0, 10, 0, 0),
                PickUpDays = "Monday - Friday",
                ClosingPickUpHours = new TimeSpan(0, 22, 0, 0)
            };
            return firstCookerHoursofOperation;
        }

        public CookerHoursofOperation SecondCookerHoursofOperation()
        {
            var secondCookerHoursofOperation = new CookerHoursofOperation
            {
                CookerId = 2,
                OpeningHours = new TimeSpan(0, 6, 0, 0),
                OpeningDays = "Monday - Thursday",
                ClosingHours = new TimeSpan(0, 18, 0, 0),

                DeliveryHours = new TimeSpan(0, 6, 0, 0),
                DeliveryDays = "Wednesday",
                ClosingDeliveryHours = new TimeSpan(0, 18, 0, 0),

                PickUpHours = new TimeSpan(0, 10, 0, 0),
                PickUpDays = "Monday - Friday",
                ClosingPickUpHours = new TimeSpan(0, 22, 0, 0)
            };
            return secondCookerHoursofOperation;
        }

        public CookerHoursofOperation ThirdCookerHoursofOperation()
        {
            var thirdCookerHoursofOperation = new CookerHoursofOperation
            {
                CookerId = 3,
                OpeningHours = new TimeSpan(0, 6, 0, 0),
                OpeningDays = "Monday - Thursday",
                ClosingHours = new TimeSpan(0, 18, 0, 0),

                DeliveryHours = new TimeSpan(0, 6, 0, 0),
                DeliveryDays = "Wednesday",
                ClosingDeliveryHours = new TimeSpan(0, 18, 0, 0),

                PickUpHours = new TimeSpan(0, 10, 0, 0),
                PickUpDays = "Monday - Friday",
                ClosingPickUpHours = new TimeSpan(0, 22, 0, 0)
            };
            return thirdCookerHoursofOperation;
        }

        ~FakeCookerHoursofOperation()
        {
            MyCookerHoursofOperations = null;
        }
    }
}
