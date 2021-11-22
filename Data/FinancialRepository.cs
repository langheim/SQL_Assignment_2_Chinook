using SQL_Assignment_2_Chinook.Interface;
using SQL_Assignment_2_Chinook.Model;
using System.Collections.Generic;
using System.Linq;

namespace SQL_Assignment_2_Chinook.Data
{
    public class FinancialRepository : Repository<Invoice>, IFinancialRepository
    {
        public FinancialRepository(ChinookContext context) : base(context)
        {
        }
        public IEnumerable<Invoice> GetHighSpenders()
        {
            List<Invoice> listReturn = new();
            var invoiceGroup = ChinookContext.Invoices.ToArray();
            var grouping = from p in invoiceGroup group p by p.CustomerId into g let numTotal = g.Sum(x => x.Total) orderby numTotal descending select new { CustomerId = g.Key, TotalSum = numTotal };

            foreach (var result in grouping)
            {
                Invoice customer = new()
                {
                    CustomerId = result.CustomerId,
                    Total = result.TotalSum,
                };
                listReturn.Add(customer);
            }
            return listReturn;
        }
        public ChinookContext ChinookContext
        {
            get { return Context as ChinookContext; }
        }
    }
}
