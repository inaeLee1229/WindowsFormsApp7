using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenericApp<T>
    {
        public string Connect(int OP, T a, T b)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int OP;
            int int_indata_1, int_indata_2;
            double double_indata_1, double_indata_2;
            Console.Write("Read OP from key ? :");
            OP = int.Parse(Console.ReadLine());
            if(OP == 0)
            {
                string Text = "double_indata_1.ToString()" + "double_indta_2.ToString()";
                Console.WriteLine(Text);
               
            }
            if(OP==1)
            {
                string Text = "int_indata_1.ToString()" + "int_indta_2.ToString()";
                Console.WriteLine(Text);
            }
        }
    }
}
