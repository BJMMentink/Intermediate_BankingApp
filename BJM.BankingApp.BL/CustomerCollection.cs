using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.BankingApp.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void PopulateTestCustomers()
        {
            Customer customer;

            customer = new Customer();
            customer.FirstName= "New";
            customer.LastName= "Year";
            customer.BirthDate = new DateTime(2000, 01, 01);
        }
        
    }
}
