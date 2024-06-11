using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsPresenter
{
    public class PersonViewModel
    {
        public string FirstName { get; }
        public string LastName { get; }

        public PersonViewModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
