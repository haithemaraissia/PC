using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Fake.Model.Util.Common
{
    public class Money
    {
        public Money()
        {
            
        }

        public decimal RoundTo2Decimal(decimal amount)
        {
            return Math.Round(amount, 2, MidpointRounding.ToEven);
        }
    }

}
