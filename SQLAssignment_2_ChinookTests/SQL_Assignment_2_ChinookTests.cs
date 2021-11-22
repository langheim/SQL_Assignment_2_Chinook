using SQL_Assignment_2_Chinook.Data;
using SQL_Assignment_2_Chinook.Model;
using System.Collections.Generic;
using Xunit;

namespace SQLAssignment_2_ChinookTests
{
    public class SQL_Assignment_2_ChinookTests
    {
        [Fact]
        public void Read_All_Customer_In_Database_Return_List_Of_Customers()
        {
            //Arrange
            var UnitOfWork = new UnitOfWork(new ChinookContext());
            List<Customer> customers = new();
            //Act
            customers = (List<Customer>)UnitOfWork.Customer.GetAll();
            //Assert
            int expected = 62;
            int actual = customers.Count;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Read_Customer_By_ID_Should_Return_CustomerName()
        {
            //Arrange
            var UnitOfWork = new UnitOfWork(new ChinookContext());
            //Act
            var customer = UnitOfWork.Customer.Get(1);
            //Assert
            string expected = "Luís";
            string actual = customer.FirstName;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Get_Customer_By_Partial_Name_Should_Return_Customer()
        {
            //Arrange
            List<Customer> listReturn = new();
            var UnitOfWork = new UnitOfWork(new ChinookContext());
            var getNamed = UnitOfWork.Customer.GetNamedCustomers("Joa", "jo");
            //Act
            foreach (Customer customer in getNamed)
            {
                Customer customer1 = new()
                {
                    FirstName = customer.FirstName
                };
                listReturn.Add(customer1);
                //Assert
                string expected = "Joakim";
                string actual = customer.FirstName;
                Assert.Equal(expected, actual);
            }
        }
        [Fact]
        public void Get_List_Of_Customers_By_Offset_Should_Return_CustomerList()
        {
            //Arrange
            var UnitOfWork = new UnitOfWork(new ChinookContext());
            List<Customer> listReturn = new();
            //Act
            var offset = UnitOfWork.Customer.GetOffset(5, 6);
            foreach (Customer customer in offset)
            {
                Customer customer1 = new()
                {
                    CustomerId = customer.CustomerId,
                };
                listReturn.Add(customer1);
            };
            //Assert
            int expected = 6;
            int actual = listReturn.Count;
            Assert.Equal(expected, actual);
        }
    }
}
