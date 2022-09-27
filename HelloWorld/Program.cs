using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS;
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("hii  !");
            Emp emp = new Emp { ID = 1, Name = "abc", Salary = 200000 };
            Console.WriteLine($"id - {emp.ID} name- {emp.Name} salary-{emp.Salary}");
        }
    }
}
