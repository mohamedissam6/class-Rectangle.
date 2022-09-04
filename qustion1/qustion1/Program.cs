using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qustion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10,15);
            Console.WriteLine(rect.Perimeter());
            Console.WriteLine(rect.Area());
            
        }
    }
}
