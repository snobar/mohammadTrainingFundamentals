using System;
using System.Collections.Generic;
using System.Text;

namespace mohammadTrainingFundamentals.Person
{
    public class clsPerson
    {
        private String _FirstName;
        private String _LastName;
        private String _Email;
        private String _Phone;

       public clsPerson() 
        {
            _FirstName="";
            _LastName="";
            _Email="";
            _Phone="";
        }
        public clsPerson(string FirstName, string LastName, string Email, string Phone)
        {
            _FirstName = FirstName;
            _LastName = LastName;
            _Email = Email;
            _Phone = Phone;
        }

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
        public string FullName()
        {
            return _FirstName + " " + _LastName;
        }
       public void Print()
        {
            Console.WriteLine( "Info:");
            Console.WriteLine( "___________________");
            Console.WriteLine( "FirstName: "+ _FirstName);
            Console.WriteLine( "LastName : "+ _LastName);
            Console.WriteLine( "Full Name: "+ FullName());
            Console.WriteLine( "Email    : "+ _Email);
            Console.WriteLine( "Phone    : "+ _Phone);
            Console.WriteLine( "___________________");

        }



    }
}
