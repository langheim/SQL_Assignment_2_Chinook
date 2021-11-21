using SQL_Assignment_2_Chinook.Interface;

namespace SQL_Assignment_2_Chinook.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ChinookContext _context;
        public UnitOfWork(ChinookContext context)
        {
            _context = context;
            Customer = new CustomerRepository(_context);
            Financials = new FinancialRepository(_context);
            Genre = new GenreRepository(_context);
        }

        public ICustomerRepository Customer { get; private set; }
        public IFinancialRepository Financials { get; private set; }
        public IGenreRepository Genre { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
