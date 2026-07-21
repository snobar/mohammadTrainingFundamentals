using System;
using System.Collections.Generic;
using System.Text;

namespace mohammadTrainingFundamentals.Person
{
    public class clsBankAccount
    {
     private string _AccountNumber;
     private string _PinCode;
     private float _AccountBalance;
        private readonly clsPerson _person;
        public string AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
        }

        public string PinCode
        {
            get
            {
                return _PinCode;
            }
            set
            {
                _PinCode = value;
            }
        }

        public float AccountBalance
        {
            get
            {
                return _AccountBalance;
            }
        }
        public clsBankAccount (clsPerson person, string AccountNumber, string PinCode, float AccountBalance)
        {
            _person = person;
            _AccountNumber = AccountNumber;
            _PinCode = PinCode;
            if (AccountBalance < 0)
                _AccountBalance = 0;
            else
                _AccountBalance = AccountBalance;
        }

        public void Print()
        {
            Console.WriteLine("Info:");
            Console.WriteLine("___________________");
            Console.WriteLine("FirstName: " + _person.FirstName);
            Console.WriteLine("LastName : " + _person.LastName);
            Console.WriteLine("Full Name: " + _person.FullName());
            Console.WriteLine("Email    : " + _person.Email);
            Console.WriteLine("Phone    : " + _person.Phone);
            Console.WriteLine("AccountNumber: " + _AccountNumber);
            Console.WriteLine("PinCode    : " + _PinCode);
            Console.WriteLine("AccountBalance    : " + _AccountBalance);
            Console.WriteLine("___________________");

        }

    }
}
