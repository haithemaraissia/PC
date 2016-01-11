using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Cookers;
using DAL.Fake.Model.LookUp.Plans;
using Model;

namespace DAL.Fake.Model.Util.Common
{
    public class Util
    {
        private readonly List<Cooker> _cookers;

        public Util()
        {
            _cookers = new FakeCookers().MyCookers;
        }
        public decimal GetTaxPercent(int cookerId)
        {
            return (from c in _cookers where c.CookerId == cookerId select c.TaxPercent).FirstOrDefault() ?? 1;
        }

        public string GetPlanTitle(int? planId)
        {
            if (planId == null) { planId = 1; }
            return Enum.GetName(typeof(Plans), planId);
        }
    }
}
