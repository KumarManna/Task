using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringSplit
{
    class StringDivide:SubString
    {
        static void Main(string[] args)
        {
            StringDivide sd = new StringDivide();
            string m = Console.ReadLine();
            List<char> k= sd.Sub(m);
            foreach(char x in k)
            {
                Console.Write(x);
            }
    
            Console.ReadKey();
        }
    }
}
