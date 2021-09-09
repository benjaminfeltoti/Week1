using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp4
{
    class Person
    {
        public string FullName 
        {
            get 
            {
                return LastName + " " + FirstName;
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
