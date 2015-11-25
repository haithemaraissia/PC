using System;
using System.Collections.Generic;
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
            MyInvoices = new List<Invoice> {
                FirstInvoice(), 
                SecondInvoice(),
                ThirdInvoices()
            };
        }

        public Invoice FirstInvoice()
        {
            var firstInvoice = new Invoice
            {
                InvoiceId = 1,
                OrderId = 1,
                Date = DateTime.Today,

            };
            return firstInvoice;
        }

        public Invoice SecondInvoice()
        {
            var secondInvoice = new Invoice
            {
                InvoiceId = 2,
                OrderId = 2,
                Date = DateTime.Today
            };
            return secondInvoice;
        }

        public Invoice ThirdInvoices()
        {
            var thirdInvoice = new Invoice
            {
                InvoiceId = 3,
                OrderId = 3,
                Date = DateTime.Today
            };
            return thirdInvoice;
        }

        ~FakeClientInvoices()
        {
            MyInvoices = null;
        }
    }
}
