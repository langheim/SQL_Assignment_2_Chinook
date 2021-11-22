using SQL_Assignment_2_Chinook.Model;
using System.Collections.Generic;

namespace SQL_Assignment_2_Chinook.Interface
{
    public interface IFinancialRepository : IRepository<Invoice>
    {
        /// <summary>
        /// Spesific functions not based on generic IRepository
        /// </summary>
        /// Get customers by how much they have spent (by invoice)
        /// <returns></returns>
        IEnumerable<Invoice> GetHighSpenders();
    }
}
