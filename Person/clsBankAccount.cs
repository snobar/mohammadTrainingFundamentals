using System;
using System.Collections.Generic;
using System.Text;

namespace mohammadTrainingFundamentals.Person
{
    public class clsBankAccount: clsPerson
    {
     private string _AccountNumber;
     private string _PinCode;
     private float _AccountBalance;

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
        public clsBankAccount ( string FirstName, string LastName, string Email, string Phone, string AccountNumber, string PinCode, float AccountBalance) :
            base(FirstName, LastName, Email, Phone)
        {
            
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
            Console.WriteLine("FirstName: " + FirstName);
            Console.WriteLine("LastName : " + LastName);
            Console.WriteLine("Full Name: " + FullName());
            Console.WriteLine("Email    : " + Email);
            Console.WriteLine("Phone    : " + Phone);
            Console.WriteLine("AccountNumber: " + _AccountNumber);
            Console.WriteLine("PinCode    : " + _PinCode);
            Console.WriteLine("AccountBalance    : " + _AccountBalance);
            Console.WriteLine("___________________");

        }

    }
}
