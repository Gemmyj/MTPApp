using MtpApp.Entity;
using System.Collections.Generic;

namespace MtpApp.Core
{
    public interface ICustomerService
    {
        int Count();
        Customer CreateCustomer(Customer customer);
        Customer DeleteCustomer(int id);
        Customer FindCustomerById(int id);
        IEnumerable<Customer> GetAllCustomers();
        Customer NewCustomer(string firstname, string lastname);
        Customer UpdateCustomer(Customer customerUpdate);
    }
}