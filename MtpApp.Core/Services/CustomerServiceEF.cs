using System;
using System.Collections.Generic;
using System.Text;
using MtpApp.Core;
using MtpApp.DataAccess;
using MtpApp.Entity;
using System.Linq;



namespace MtpApp.Core.Services
{
   public class CustomerServiceEF : ICustomerService
    {
        private MTPDataContext _ctx;

        public CustomerServiceEF(MTPDataContext ctx)
        {
            _ctx = ctx;
        }
        public int Count()
        {


           return _ctx.Customers.Count();

            
        }

        public Customer CreateCustomer(Customer customer)
        {
            Customer c = _ctx.Customers.Add(customer).Entity;
            _ctx.SaveChanges();
            return c;
        }

        public Customer DeleteCustomer(int id)
        {
            Customer o = _ctx.Customers.SingleOrDefault(c => c.Id == id);

            if (o == null)
            {
                return null;

            }
           
            _ctx.Customers.Remove(o);

            _ctx.SaveChanges();

            return o;
        }

        public Customer FindCustomerById(int id)
        {
            Customer a = _ctx.Customers.SingleOrDefault(c => c.Id == id);
            return a;
           
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _ctx.Customers.ToList();
        }

        public Customer NewCustomer(string firstname, string lastname)
        {
            Customer customer = new Customer();

            customer.FirstName = firstname.Trim();
            customer.LastName = lastname.Trim();

            Customer b = _ctx.Customers.Add(customer).Entity;
            _ctx.SaveChanges();
            return b;
        }

        public Customer UpdateCustomer(Customer customerUpdate)
        {
            Customer o = _ctx.Customers.SingleOrDefault(c => c.Id == customerUpdate.Id);

            if (o == null)
            {
                return null;

            }
            o.FirstName = customerUpdate.FirstName;
            o.LastName = customerUpdate.LastName;
            o.Address = customerUpdate.Address;
            o.Telephone = customerUpdate.Telephone;

            Customer u =  _ctx.Customers.Update(o).Entity;

            _ctx.SaveChanges();

            return u;
        }
    }
}
