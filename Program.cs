﻿using SQL_Assignment_2_Chinook.Data;
using System;

namespace SQL_Assignment_2_Chinook
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var UnitOfWork = new UnitOfWork(new Data.ChinookContext()))
            {

                //Console.WriteLine("1. Read all customers in the database");
                //Console.ReadLine();
                //UnitOfWork.Customer.GetAllCustomers();
                //Console.ReadLine();
                //Console.Clear();

                //Console.WriteLine("2. Read a spesific customer by ID");
                //Console.ReadLine();
                //var customer = UnitOfWork.Customer.Get(10);
                //    Console.WriteLine($"" +
                //        $"ID: {customer.CustomerId}\n " +
                //        $"Name: {customer.FirstName} {customer.LastName}\n " +
                //        $"Country: {customer.Country}\n " +
                //        $"Postalcode: {customer.PostalCode}\n " +
                //        $"PhoneNumber: {customer.Phone}\n " +
                //        $"E-Mail: {customer.Email} ");
                //Console.ReadLine();
                //Console.Clear();

                //Console.WriteLine("3. Read a customer by name (Name can be partial, example here is for Joh*)");
                //Console.ReadLine();
                //UnitOfWork.Customer.GetNamedCustomers("Joh");
                //Console.ReadLine();
                //Console.Clear();

                //Console.WriteLine("4. Retrive a subset of customerdata");
                //Console.ReadLine();
                //UnitOfWork.Customer.GetLimitedListOfCustomers(5,10);
                //Console.ReadLine();
                //Console.Clear();

                ////Console.WriteLine("5. Add a new customer to the Database");
                ////Console.ReadLine();
                ////UnitOfWork.Customer.Add(
                ////new Customer
                ////{
                ////    FirstName = "Ola",
                ////    LastName = "Normann",
                ////    Country = "Norway",
                ////    PostalCode = "9999",
                ////    Phone = "87654321",
                ////    Email = "ola@norge.com",
                ////});
                ////UnitOfWork.Complete();

                ////Console.ReadLine();
                ////Console.Clear();

                //Console.WriteLine("6. Update existing customer");
                //int customernr = 60;
                //var updateCustomer = UnitOfWork.Customer.Get(customernr);
                //    // Validate entity is not null
                //    if (updateCustomer != null)
                //    {
                //        // Make changes on customer objects
                //        updateCustomer.FirstName = "Brummen";
                //        updateCustomer.LastName = "Dahl";

                //        // Update database
                //        UnitOfWork.Complete();
                //    }
                //var updatedCustomer = UnitOfWork.Customer.Get(customernr);
                //    Console.WriteLine($"" +
                //    $"ID: {updatedCustomer.CustomerId}\n " +
                //    $"Name: {updatedCustomer.FirstName} {updatedCustomer.LastName}\n " +
                //    $"Country: {updatedCustomer.Country}\n " +
                //    $"Postalcode: {updatedCustomer.PostalCode}\n " +
                //    $"PhoneNumber: {updatedCustomer.Phone}\n " +
                //    $"E-Mail: {updatedCustomer.Email} ");
                //Console.ReadLine();
                //Console.Clear();

                //Console.WriteLine("7. Return a sorted number of customers in each country");
                //Console.ReadLine();
                //UnitOfWork.Customer.GetNrOfCustomersByCountry();
                //Console.ReadLine();
                //Console.Clear();

                Console.WriteLine("8. Customers who are the highest spenders");
                UnitOfWork.Financials.GetHighSpenders();
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("9. for a given customer their most popular Genre");
                UnitOfWork.Genre.GetPopularGenreByCustomer(10);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}