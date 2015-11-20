using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeRefundStatus
    {
        public List<OrderDetail> MyOrderDetails;

        public FakeRefundStatus()
        {
            InitializeOrderDetailList();
        }

        public void InitializeOrderDetailList()
        {
            MyOrderDetails = new List<OrderDetail> {
                FirstOrderDetail(), 
                SecondOrderDetail(),
                ThirdOrderDetail()
            };
        }

        public OrderDetail FirstOrderDetail()
        {
            var firstOrderDetail = new OrderDetail
            {
                OrderDetailId = 1,
                DishId =  1,
                CookerId = 1,
                MenuId = 1,
                Quantity = 1,
                OrderId = 1
            };
            return firstOrderDetail;
        }

        public OrderDetail SecondOrderDetail()
        {
            var secondOrderDetail = new OrderDetail
            {
                OrderDetailId = 2,
                UserId = 4
            };
            return secondOrderDetail;
        }

        public OrderDetail ThirdOrderDetail()
        {
            var thirdOrderDetail = new OrderDetail
            {
                OrderDetailId = 3,
                UserId = 6
            };
            return thirdOrderDetail;
        }

        ~FakeRefundStatus()
        {
            MyOrderDetails = null;
        }
    }
}
