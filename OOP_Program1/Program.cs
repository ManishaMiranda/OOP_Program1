using System;

namespace OOP_Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Supervisor supervisor = new Supervisor("Manisha","Miranda","Clinton","Professor");
            Console.WriteLine(supervisor.getName());
            Console.WriteLine(supervisor.Supervisor1());
        }
    }
}
