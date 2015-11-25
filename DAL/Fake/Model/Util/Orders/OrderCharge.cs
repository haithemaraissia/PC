using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Cooker;
using DAL.Fake.Model.GoodData.DeliveryZones;
using DAL.Fake.Model.GoodData.Orders.Clients;
using DAL.Fake.Model.KMLHelper;
using Model;
using Model.Helper;

namespace DAL.Fake.Model.Util.Orders
{
    public class OrderCharge
    {
        private readonly List<Cooker> _cookers;
        private readonly List<OrderItem> _orderItem;
        private readonly List<DeliveryZone> _deliveryZones;
        private readonly List<CookerDeliveryZone> _cookerDeliveryZones;
        private readonly ClientAddress _deliveryAddress;
        public OrderCharge(ClientAddress deliveryAddress = null)
        {
            _cookers = new FakeCookers().MyCookers;
            _orderItem = new FakeOrderItems().MyOrderItems;
            _deliveryZones = new FakeDeliveryZone().MyDeliveryZones;
            _cookerDeliveryZones = new FakeCookerDeliveryZone().MyCookerDeliveryZones;

            if (deliveryAddress != null)
            {
                _deliveryAddress = deliveryAddress;
            }
        }

        public OrderChargeModel Calculate(Order order)
        {
            var orderItems = (from c in _orderItem where c.OrderId == order.OrderId select c).ToList();
            var cookerid = orderItems.First().CookerId;
            var taxPercent = (from c in _cookers where c.CookerId == cookerid select c.TaxPercent).FirstOrDefault();

            #region PickUpOrderCharge

            if (order.OrderTypeId == (int)OrderType.Values.PickUp)
            {
               return  PickUpCharge(order, taxPercent);
            }

            #endregion
 
            #region DeliveryOrderCharge

            var cookerDelieryZonesId = (from c in _cookerDeliveryZones where c.CookerId == cookerid select c.DeliveryId).ToList();

            decimal deliveryFees = 0;
            foreach (var deliveryZoneId in cookerDelieryZonesId)
            {
                //Custom KML Function to see if the item is in the zone
                //Moq for now
                var deliveryzone = _deliveryZones.FirstOrDefault(c => c.DeliveryId == (int)deliveryZoneId);

                //KML integration to see if deliveryaddress is Zone
                if (_deliveryAddress.AddressTypeId == (int) AddressToDeliveryZone.Values.AddressInZone)
                {
                    if (deliveryzone != null)
                    {
                        deliveryFees = deliveryzone.DeliveryFees;
                    }
                }
            }

            return DeliveryCharge(order, deliveryFees, taxPercent); 

            #endregion
        }

        #region Order Charges

        private OrderChargeModel PickUpCharge(Order order, decimal? taxPercent)
        {
            if (taxPercent == null)
            {
                taxPercent = 1;
            }
            return new OrderChargeModel
            {
                deliveryFee = 0,
                salesTaxes = (decimal) (order.SubTotal * taxPercent),
                Subtotal = order.SubTotal,
                totalCharges = ((decimal) (order.SubTotal * taxPercent)+ order.SubTotal )
            };
        }

        private OrderChargeModel DeliveryCharge(Order order, decimal deliveryFee, decimal? taxPercent)
        {
            if (taxPercent == null)
            {
                taxPercent = 1;
            }
            return new OrderChargeModel
            {
                deliveryFee = deliveryFee,
                salesTaxes = (decimal) ((order.SubTotal + deliveryFee) * taxPercent),
                Subtotal = order.SubTotal,
                totalCharges = ((decimal) (deliveryFee + (order.SubTotal + deliveryFee) * taxPercent) + order.SubTotal)
            };
        }
        
        #endregion
   
    }
}
