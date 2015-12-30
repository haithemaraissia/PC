using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cookers
{
    public class FakeCookerReviewServiceDetails
    {
        public List<CookerReviewServiceDetail> MyCookerReviewServiceDetails;

        public FakeCookerReviewServiceDetails()
        {
            InitializeCookerReviewServiceDetailList();
        }

        public void InitializeCookerReviewServiceDetailList()
        {
            MyCookerReviewServiceDetails = new List<CookerReviewServiceDetail> {
                FirstCookerReviewServiceDetail()
            };
        }

        public CookerReviewServiceDetail FirstCookerReviewServiceDetail()
        {
            var firstCookerReviewServiceDetail = new CookerReviewServiceDetail
            {
                CookerReviewServiceDetailId = 1,
                CookerId = 1,
                ItemAccuracyRating = 1,
                CommunicationRating = 4,
                DeliveryTimeRating = 5,
                OverallFeedBackRating = 2,
                NumberofRatings = 7
            };
            return firstCookerReviewServiceDetail;
        }


        ~FakeCookerReviewServiceDetails()
        {
            MyCookerReviewServiceDetails = null;
        }
    }
}
