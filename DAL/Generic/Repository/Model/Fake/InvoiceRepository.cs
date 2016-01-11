using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Invoices;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeInvoiceRepository : FakeGenericRepository<Invoice>, IInvoiceRepository
    {
	    public FakeInvoiceRepository(): base(new FakeInvoices().MyInvoices)
        {
        }

        public FakeInvoiceRepository(List<Invoice> myInvoices): base(myInvoices)
        {
        }
    }
}
       