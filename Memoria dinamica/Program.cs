using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria_dinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> dynamicList = new List<int>();

            Console.WriteLine("Enter numbers (0 to stop):");

            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                    break;

                dynamicList.Add(input);
            }

            Console.WriteLine("Entered numbers:");
            foreach (int number in dynamicList)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}
                 