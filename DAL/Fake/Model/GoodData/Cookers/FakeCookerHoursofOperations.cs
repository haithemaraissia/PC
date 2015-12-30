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
                OpeningHours = "6.00 am",
                OpeningDays = "Monday - Thursday",
                DeliveryDays = "Wednesday",
                DeliveryHours = "Same as opening",
                PickUpHours = "12:00 am - 12:00 pm",
                PickUpDays = "Monday - Friday"
            };
            return firstCookerHoursofOperation;
        }

        public CookerHoursofOperation SecondCookerHoursofOperation()
        {
            var secondCookerHoursofOperation = new CookerHoursofOperation
            {
                CookerId = 2,
                OpeningHours = "11.00 am",
                OpeningDays = "Monday , Tuesday, Thursday, Friday",
                DeliveryDays = "Wednesday",
                DeliveryHours = "Monday and Tuesday",
                PickUpHours = "12:00 am - 12:00 pm",
                PickUpDays = "Monday - Friday"
            };
            return secondCookerHoursofOperation;
        }

        public CookerHoursofOperation ThirdCookerHoursofOperation()
        {
            var thirdCookerHoursofOperation = new CookerHoursofOperation
            {
                CookerId = 3,
                OpeningHours = "6.00 am",
                OpeningDays = "Monday - Thursday",
                DeliveryDays = "Wednesday",
                DeliveryHours = "Same as opening",
                PickUpHours = "12:00 am - 12:00 pm",
                PickUpDays = "Monday - Friday"
            };
            return thirdCookerHoursofOperation;
        }

        ~FakeCookerHoursofOperation()
        {
            MyCookerHoursofOperations = null;
        }
    }
}
