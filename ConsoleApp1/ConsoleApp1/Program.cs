using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 12;
            int y1 = 10;
            char sym1 = '#';

            Draw(x1, y1, sym1);

        }
        static void Draw(int x1, int x2, char sym)
            {
                Console.SetCursorPosition( x1, x2);
                Console.Write( sym );
                Console.ReadKey();
            }
    }
}
