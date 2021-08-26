using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise01.Exercise01 exercise01 = new Exercise01.Exercise01();
            int numb;
            Console.WriteLine("Enter Numbers Up To 99,999");
            numb = Int32.Parse(Console.ReadLine());

            if (numb>=100000)
            {
            Console.WriteLine("Please Enter Numbers Up To 99,999");
            numb = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine(exercise01.Towards(numb));
            Console.ReadKey();
           
        }
    }
}
