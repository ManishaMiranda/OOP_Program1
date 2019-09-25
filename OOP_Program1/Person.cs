using System;

namespace OOP_Program1
{
    class Person
    {
        public string firstName;
        public string lastName;



        public string getName()
        {
            return firstName + " " + lastName;
        }


        public Person()
        {
            firstName = "Manisha";
            lastName = "Miranda";
        }


        public Person(string lname)
        {
            lastName = lname;
        }
    }
}