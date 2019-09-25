using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Program1
{
    class Supervisor : Person
    {
        public string SupervisorName;
        public string SupervisorDesignation;



        public string Supervisor1()
        {
            return firstName + " " + lastName + "is supervised by" + " " +SupervisorName +"-" + SupervisorDesignation;
        }

        public Supervisor(string firstName, string lastName, string SupervisorName, string SupervisorDesignation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.SupervisorName = SupervisorName;
            this.SupervisorDesignation = SupervisorDesignation;
        }

        
    }
}