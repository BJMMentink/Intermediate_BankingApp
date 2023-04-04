using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.BankingApp.BL
{
    public class Person
    {
        public string SSN { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string FullName 
        { 
            get;  
        } 
        public string Age { get; set; } = "";
        public string BirthDate { get; set; } = "";
    }
}
