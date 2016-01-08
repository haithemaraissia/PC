using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TimeSpanTest
    {
        //   public OwnersController Controller;

        [TestInitialize]
        public void Initialize()
        {
            // Arrange
           //  var cookerRepo = new FakeCookerRepository();
           //  var uow = new UnitofWork { CookerRepository = cookerRepo };
           // Controller = new OwnersController(uow);
        }

        [TestMethod]
        public void Time()
        {
            #region TimeSpan 
            var openingHours = new TimeSpan(0, 6, 0, 0);
            var closingHours = new TimeSpan(0, 18, 0, 0);
            var openingHoursTimeDisplay = openingHours.ToString(@"hh\:mm");
            var closingHoursTimeDisplay = closingHours.ToString(@"hh\:mm");
            Assert.AreEqual("06:00", openingHoursTimeDisplay);
            Assert.AreEqual("18:00", closingHoursTimeDisplay);
            #endregion

            #region TimeSpanWithAMPM
            DateTime openingHoursDatetime = DateTime.Today.Add(openingHours);
            var openingHoursTimeDisplayWithAmpm = openingHoursDatetime.ToString(@"hh\:mm tt");
            DateTime closingHoursDatetime = DateTime.Today.Add(closingHours);
            var closingHoursTimeDisplayWithAmpm = closingHoursDatetime.ToString(@"hh\:mm tt");
            Assert.AreEqual("06:00 AM", openingHoursTimeDisplayWithAmpm);
            Assert.AreEqual("06:00 PM", closingHoursTimeDisplayWithAmpm);
            #endregion

            #region IsOpen or IsClose

            var now = DateTime.UtcNow.TimeOfDay;
            Assert.AreEqual(true, now >= openingHours);
            Assert.AreEqual(true, now >= openingHoursDatetime.TimeOfDay);

            Assert.AreEqual(true, now <= closingHours);
            Assert.AreEqual(true, now <= closingHoursDatetime.TimeOfDay);
            #endregion
        }
        //public void IndexShouldListAllOwners()
        //{
        //    // Act
        //    var actual = Controller.Index();

        //    // Assert
        //    var viewResult = actual as ViewResult;
        //    if (viewResult == null) return;
        //    var data = viewResult.ViewData.Model as IList<Owner>;
        //    if (data != null) Assert.AreEqual(3, data.Count);
        //}

        [TestCleanup]
        public void CleanUp()
        {
            //  Controller.Dispose();
        }
    }
}
