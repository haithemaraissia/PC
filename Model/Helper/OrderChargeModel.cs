using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Helper
{
    public class OrderChargeModel
    {
        public decimal Subtotal { get; set; }
        public decimal deliveryFee { get; set; }
        public decimal salesTaxes { get; set; }
        public decimal totalCharges { get; set; }
    }
}
