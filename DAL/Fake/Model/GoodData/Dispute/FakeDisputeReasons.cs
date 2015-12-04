﻿using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Dispute
{
    public class FakeDisputeReason
    {
        public List<DisputeReason> MyDisputeReasons;

        public FakeDisputeReason()
        {
            InitializeDisputeReasonList();
        }

        public void InitializeDisputeReasonList()
        {
            MyDisputeReasons = new List<DisputeReason> {
                FirstDisputeReason(), 
                SecondDisputeReason()
            };
        }

        public DisputeReason FirstDisputeReason()
        {
            var firstDisputeReason = new DisputeReason
            {
                DisputeReasonId = 1,
                DisputeReasonValue = "Item not as described"
            };
            return firstDisputeReason;
        }

        public DisputeReason SecondDisputeReason()
        {
            var secondDisputeReason = new DisputeReason
            {
                DisputeReasonId = 2,
                DisputeReasonValue = "Other reasons"
            };
            return secondDisputeReason;
        }


        ~FakeDisputeReason()
        {
            MyDisputeReasons = null;
        }
    }
}
