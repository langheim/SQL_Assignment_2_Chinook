using SQL_Assignment_2_Chinook.Interface;
using SQL_Assignment_2_Chinook.Model;
using System;
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
            var invoiceGroup = ChinookContext.Invoices.ToArray();
            var grouping = from p in invoiceGroup group p by p.CustomerId into g let numTotal = g.Sum(x => x.Total) orderby numTotal descending select new { CustomerId = g.Key, TotalSum = numTotal };

            foreach (var result in grouping)
            {
                Console.WriteLine($"Customer Id: {result.CustomerId}\t Total invoiced: {result.TotalSum}$");
            }
            return invoiceGroup.ToArray();
        }
        public ChinookContext ChinookContext
        {
            get { return Context as ChinookContext; }
        }
    }
}
