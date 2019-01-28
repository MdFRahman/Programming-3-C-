using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextDemo
{
    class PersonalDetails
    {
        string _firstName = "Bob";
        string _lastName = "Smith";
        int _age = 25;
        static PersonalDetails _details;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public static PersonalDetails GetDetails()
        {
            if (_details == null)
                _details = new PersonalDetails();

            return _details;
        }
    }
}
