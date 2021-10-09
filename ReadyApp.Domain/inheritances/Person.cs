using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain.inheritances
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = $"{LastName}, {FirstName}"; }
        }

    }
}
