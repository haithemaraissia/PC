using System;
using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Orders.Clients.Client1;
using DAL.Fake.Model.GoodData.Orders.Clients.Client2;
using DAL.Fake.Model.GoodData.Orders.Clients.Client3;
using Model;

namespace DAL.Fake.Model
{
    public class FakeClientInvoices
    {
        public List<Invoice> MyInvoices;

        public FakeClientInvoices()
        {
            InitializeInvoicesList();
        }

        public void InitializeInvoicesList()
        {
            MyInvoices = new List<Invoice>();
            var client1Invoices = new FakeClient1Invoices().MyInvoices;
            foreach (var invoice in client1Invoices)
            {
                MyInvoices.Add(invoice);
            }
            var client2Invoices = new FakeClient2Invoices().MyInvoices;
            foreach (var invoice in client2Invoices)
            {
                MyInvoices.Add(invoice);
            }
            var client3Invoices = new FakeClient3Invoices().MyInvoices;
            foreach (var invoice in client3Invoices)
            {
                MyInvoices.Add(invoice);
            }

        }


        ~FakeClientInvoices()
        {
            MyInvoices = null;
        }
    }
}
