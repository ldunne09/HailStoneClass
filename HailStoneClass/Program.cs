using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HailStoneClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"args[{i}]={args[i]}");
            }*/
            foreach(var arg in args)
               System.Console.WriteLine($"arg is {arg}");
            

           var hs = new HailStoneClass(7);
            Console.WriteLine("Hello World!");
        }
    }
}
