//namespace
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList parliamentConst = new ArrayList();

            parliamentConst.Add("Puchong");
            parliamentConst.Add("Subang");
            parliamentConst.Add("Sungai Buloh");
            parliamentConst.Add("Sungai Besi");

            foreach (string s in parliamentConst)
            {
                Console.WriteLine(s);
            }
            

          /*  for (int c = 0; c < parliamentConst.Count; c++)
            {
                Console.WriteLine(parliamentConst[c]);
            } */

            parliamentConst.Sort();
            foreach (string s in parliamentConst)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("**********************");
            Console.WriteLine(parliamentConst);
            Console.WriteLine("**********************");
            Console.WriteLine(parliamentConst.Count);

            parliamentConst.Insert(2, "Shah Alam");
            Console.WriteLine(parliamentConst.Count);
            parliamentConst.Sort();
            foreach (string s in parliamentConst)
            {
                Console.WriteLine(s);
            }

            if (parliamentConst.IndexOf("Titiwangsa") >= 0)
            {
                Console.WriteLine("Titiwangsa is in the list");
            }
            else
            {
                Console.WriteLine("Titiwangsa is not in the list"); 
            }


            if (parliamentConst.IndexOf("Subang") >= 0)
            {
                Console.WriteLine("Subang is in the list");
            }
            else
            {
                Console.WriteLine("Titiwangsa is not in the list");
            }

            Console.WriteLine("**********************");

            Console.ReadKey();



        }
    }
}
