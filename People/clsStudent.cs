using System;
using System.Collections.Generic;
using System.Text;

namespace mohammadTrainingFundamentals.People
{
    public class clsStudent 
    {
        private string _Mejor = string.Empty;
        private string _IdStudent = string.Empty;
        private readonly clsPerson _Person ;

        public clsStudent(clsPerson P, string Mejor, string IdStudent)
        {
            _Person = P;
            _Mejor = Mejor;
            _IdStudent = IdStudent;
        }
        public void Print()
        {

                Console.WriteLine("Info:");
                Console.WriteLine("___________________");
                Console.WriteLine("FirstName: " + _Person.FirstName);
                Console.WriteLine("LastName : " + _Person.LastName);
                Console.WriteLine("Full Name: " + _Person.FullName());
                Console.WriteLine("Email    : " + _Person.Email);
                Console.WriteLine("Phone    : " + _Person.Phone);
                Console.WriteLine("Mejor    : " + _Mejor);
                Console.WriteLine("IdStudent: " + _IdStudent);
                Console.WriteLine("___________________");

        }

    }
}
