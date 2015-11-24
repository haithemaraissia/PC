using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Fake.Model.GoodData.Cooker;
using DAL.Fake.Model.GoodData.Cooker.Dishes;
using DAL.Fake.Model.GoodData.Orders.Clients;
using Model;

namespace DAL.Fake.Model.Util.Orders
{
    public class OrderCharge
    {
        //Subtotal
        //$25.62
        //Delivery Fee:
        //$7.64
        //Sales Tax:
        //$3.33

        private List<Cooker> cookers;
        private List<OrderItem> orderItem;

        public OrderCharge()
        {
            cookers = new FakeCookers().MyCookers;
            orderItem = new FakeOrderItems().MyOrderItems;
        }

        public void Calculate(Order order)
        {


            var orderItems = (from c in orderItem where c.OrderId == order.OrderId select c).ToList();
            var cookerid = orderItems.First().CookerId;


            var taxPercent = from c in cookers where c.CookerId == cookerid select c.TaxPercent;
            var subtotal = order.SubTotal;

        }

        public void PickUpCharge(Order order)
        {
            
        }


        public void DeliveryCharge(Order order)
        {

        }
    }
}
