using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inital prompt
            Console.WriteLine("INFORMATION INPUT");
            //Asks for first name
            Console.WriteLine("What is your first name?");
            //Recieves name and assigns it to firstName string
            string firstName = Console.ReadLine();
            //Asks last name
            Console.WriteLine("What is your last name?");
            //Gets name, assigns to lastName
            string lastName = Console.ReadLine();
            //Asks age
            Console.WriteLine("What is your age?");
            //Gets age to age string
            string age = Console.ReadLine();
            //Asks favorite number
            Console.WriteLine("What is your favorite number?");
            //Gets number string
            string favNum = Console.ReadLine();
            //Uses all previous info and prints it into sentence
            Console.WriteLine("Hello, " + firstName + " " + lastName + "! You are " + age + " years old, and your favorite number is " + favNum + ".");
        }
    }
}