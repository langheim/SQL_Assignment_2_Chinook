using SQL_Assignment_2_Chinook.Model;
using System.Collections.Generic;

namespace SQL_Assignment_2_Chinook.Interface
{
    public interface IFinancialRepository : IRepository<Invoice>
    {
        IEnumerable<Invoice> GetHighSpenders();
    }
}
