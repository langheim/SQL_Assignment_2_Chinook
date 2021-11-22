using SQL_Assignment_2_Chinook.Interface;

namespace SQL_Assignment_2_Chinook.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Using unit of work for a more generic access to DbContext
        /// </summary>
        private readonly ChinookContext _context;
        public UnitOfWork(ChinookContext context)
        {
            _context = context;
            Customer = new CustomerRepository(_context);
            Financials = new FinancialRepository(_context);
            Genre = new GenreRepository(_context);
        }
        /// <summary>
        /// Creating 3 repositories for creation
        /// </summary>
        public ICustomerRepository Customer { get; private set; }
        public IFinancialRepository Financials { get; private set; }
        public IGenreRepository Genre { get; private set; }
        /// <summary>
        /// Adding this for simplicaty to run after an update
        /// </summary>
        /// <returns></returns>
        public int Complete()
        {
            return _context.SaveChanges();
        }
        /// <summary>
        /// Used to Dispose of item, for accessabillity 
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
