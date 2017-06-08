using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This class contains methods related to saving the users input.
/// </summary>

namespace AddressBook {

    class SaveToAddressBook {

        public string FirstName;
        public string LastName;

        public SaveToAddressBook(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        //TODO: Fix this shitty input validation.
        public bool IsValidEntry() {
            if(FirstName == null) {
                return false;
            }
            else if(LastName == null) {
                return false;
            }
            else {
                return true;
            }

            
        }

    }
}
