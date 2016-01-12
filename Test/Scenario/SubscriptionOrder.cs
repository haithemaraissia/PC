using System;
using System.Linq;
using DAL.Generic.Repository.Model.Fake;
using DAL.Generic.UnitofWork;
using DAL.Generic.UnitofWork.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.Fake.Model.LookUp.OrderModel;

namespace Test.Scenario
{
    /// <summary>
    /// Scenario:
    ///     Client subscribe to a cooker subscription
    ///     Client check the subscipriont detail
    ///     An Invoice is genereated
    ///     A payment is made

    ///     Cooker Reciever Order
    ///     Change its status to done

    ///     Client submit a review for the first dish in the subscrption
    ///     Cooker Submit review
    ///     Cooker review is calculated for subscriptions
    /// </summary>


    [TestClass]
    public class SubscriptionOrder
    {

        [TestInitialize]
        public void Initialize()
        {
            // Arrange
            //var cookerRepo = new FakeCookerRepository();
           // var uow = new UnitofWorkHelper().GetAllRepository();
            // Controller = new OwnersController(uow);//
        }


        [TestMethod]
        public void Test()
        {
            //  Client subscribe to a cooker subscription
           var uow = new UnitofWorkHelper().GetAllRepository();
            var cookerSubscriptionCount = uow.CookerSubscriptionRepository.All.Count();
            Assert.AreEqual(cookerSubscriptionCount, 3);
        }




        #region Prototype
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
        #endregion

        [TestCleanup]
        public void CleanUp()
        {
            //  Controller.Dispose()
        }
    }
}