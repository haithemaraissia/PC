using DAL.Data.UnitofWork;
using DAL.Fake.Repo.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Scenario
{
    /// <summary>
    /// Scenario:
    ///     Client make a transction  order
    ///     An Invoice is genereated
    ///     A payment is made

    ///     Cooker Reciever Order
    ///     Change its status to done

    ///     Client submit a review
    ///     Cooker Submit review
    ///     Cooker review is calculated
    /// </summary>


    [TestClass]
    public class TransactionOrder
    {

        [TestInitialize]
        public void Initialize()
        {
            // Arrange
            //var clientRepo = new FakeClientRepository();
            var cookerRepo = new FakeCookerRepository();
            //var cookerRepo = new FakeCookerRepository();
            //var cookerRepo = new FakeCookerRepository();
            //var cookerRepo = new FakeCookerRepository();
            //var cookerRepo = new FakeCookerRepository();
            //var cookerRepo = new FakeCookerRepository();
            //var cookerRepo = new FakeCookerRepository();
            var uow = new UnitofWork { CookerRepository = cookerRepo };
            // Controller = new OwnersController(uow);//
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
            //  Controller.Dispose()
        }
    }
}