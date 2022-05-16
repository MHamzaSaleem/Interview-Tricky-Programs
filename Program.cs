using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Hamza", "Sikander", "Abdullah", "Zainab", "Tehreem", "Sikander", "Sikander", "Sikander", "Hamza", "Sikander", "Hamza", "Hamza", "Tehreem", "Zainab", "Tehreem" };
            var name = names.ToList();

            var result = new List<Tuple< int, string>>();
            int i=0;
            while(true)
            {
                if (name.Count < 1)
                    break;
                var count = names.Where(x => x == names[i]).Count();
                if (result.Where(x=>x.Item2 == names[i]).FirstOrDefault()==null)
                {
                    result.Add(Tuple.Create(count, names[i]));
                    name.RemoveAll(x => x == names[i]);
                }
                i++;
            }
            for (i = 0; i < result.Count; i++)
            {
                Console.WriteLine("Name: "+ result[i].Item2 + ", Count: " + result[i].Item1);
            }
            Console.ReadLine();
        }
    }
}
