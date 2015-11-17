using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.UnitofWork;
using DAL.Fake.Repo.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class InitTest
    {

        [TestInitialize]
        public void Initialize()
        {
            // Arrange
            var clientRepo = new FakeClientRepository();
            var cookerRepo = new FakeCookerRepository();
            var cookerRepo = new FakeCookerRepository();
            var cookerRepo = new FakeCookerRepository();
            var cookerRepo = new FakeCookerRepository();
            var cookerRepo = new FakeCookerRepository();
            var cookerRepo = new FakeCookerRepository();
            var cookerRepo = new FakeCookerRepository();
            var uow = new UnitofWork { CookerRepository = cookerRepo };
            // Controller = new OwnersController(uow);
        }
        //Test





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




           
//Core
//A Client buy a serving menu from a Chef.

//Then, the client will submit a review.

//Chef will also submit a review.
        }
    }
}
