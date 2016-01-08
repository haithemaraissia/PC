using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class InvoiceRepository : FakeGenericRepository<Invoice>, IInvoiceRepository
    {
	    public InvoiceRepository(): base(new FakeInvoices().MyInvoices)
        {
        }

        public InvoiceRepository(List<Invoice> myInvoices): base(myInvoices)
        {
        }
    }
}
       