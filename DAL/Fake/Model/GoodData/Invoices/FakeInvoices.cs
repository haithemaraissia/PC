using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Invoices.Client.Client1;
using Model;

namespace DAL.Fake.Model.GoodData.Invoices
{
    public class FakeInvoices
    {
        public List<Invoice> MyInvoices;
        public FakeInvoices()
        {
            InitializeInvoiceList();
        }

        public void InitializeInvoiceList()
        {
            MyInvoices = new List<Invoice>();
            var client1Invoices = new FakeClient1Invoices().MyInvoices;
            foreach (var invoice in client1Invoices)
            {
                MyInvoices.Add(invoice);
            }

            //var cooker1Invoices = new FakeCooker1Invoices().MyInvoices;
            //foreach (var invoice in cooker1Invoices)
            //{
            //    MyInvoices.Add(invoice);
            //}


        }
    }
}
