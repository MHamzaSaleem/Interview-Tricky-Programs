using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TwoStringsCharactersMatching
    {
        static void Main(string[] args)
        {
            string name1 = "Aaad";
            string name2 = "asad";
            char[] nam1 = name1.ToCharArray();
            char[] nam2 = name2.ToCharArray();
            Array.Sort(nam1);
            Array.Sort(nam2);
            name1 = new String(nam1);
            name2 = new String(nam2);
            if (name1 == name2)
                Console.WriteLine("Matched");
            else
                Console.WriteLine("Not Matched");

            Console.ReadLine();
        }
    }
}
