using DAL.Data.UnitofWork;
using DAL.Generic.Repository.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class OwnersControllerTest
    {
     //   public OwnersController Controller;

        [TestInitialize]
        public void Initialize()
        {
            // Arrange
            var cookerRepo = new FakeCookerRepository();
            var uow = new UnitofWork { CookerRepository = cookerRepo };
           // Controller = new OwnersController(uow);
        }

        [TestMethod]
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
