using System;
using System.Collections.Generic;
using System.Diagnostics;
using Model;

namespace DAL.Fake.Model.GoodData.Orders.Clients.Client1
{
    public class FakeClient1OrderHistory
    {
        public List<OrderHistroy> MyClient1OrdersHistory;

        public FakeClient1OrderHistory()
        {
            InitializeClient1OrderHistoryList();
        }

        private void InitializeClient1OrderHistoryList()
        {
            MyClient1OrdersHistory = new List<OrderHistroy> {
                FirstOrderHistory()
            };
        }

        private OrderHistroy FirstOrderHistory()
        {
            var invoice = new FakeClient1Invoices().FirstInvoice();
            Debug.Assert(invoice.OrderId != null, "invoice.OrderId != null");
            var orderHistory = new OrderHistroy
            {
                OrderHistoryId = 1,
                OrderId = (int) invoice.OrderId,
                ClientId = invoice.ClientId,
                CookerId = invoice.ClientId,
                OrderTypeValue = invoice.OrderTypeValue,
                PaymentMethodValue = invoice.PaymentMethodValue,
                PromotionTitle = invoice.PromotionTitle,
                PromotionPrice = invoice.PromotionPrice,
                PromotionCurrencyId = invoice.PromotionCurrencyId,
                CouponTitle = invoice.CouponTitle,
                CouponPrice = invoice.CouponPrice,
                CouponCurrencyId = invoice.CouponCurrencyId,
                PlanTitle = invoice.PlanTitle,
                SalesTax = invoice.SalesTax,
                DeliveryFees = invoice.DeliveryFees,
                SubTotal = invoice.SubTotal,
                Total = invoice.Total,
                CurrencyId = invoice.CurrencyId
            };
            return orderHistory;
        }

        ~FakeClient1OrderHistory()
        {
            MyClient1OrdersHistory = null;
        }
    }
}
