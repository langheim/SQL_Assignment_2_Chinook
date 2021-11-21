﻿using System;

namespace SQL_Assignment_2_Chinook.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customer { get; }
        IFinancialRepository Financials { get; }
        IGenreRepository Genre { get; }
        int Complete();
    }
}
