using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            SayHiUser("Nelca");
            SayHiAge("Nelca",25);
            Console.ReadLine();
        }
        static void SayHi()
        {
            Console.WriteLine("Hi");
        }
        static void SayHiUser(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
        }








        
    }
}
