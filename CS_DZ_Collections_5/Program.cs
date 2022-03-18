using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Collections_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "Привет", "Как дела?" };
            string[] array2 = { "Привет", "Что делаешь?" };

            List<string> union = Union(ref array1, ref array2);
            
            for (int i = 0; i < union.Count; i++)
            {
                Console.Write(union[i] + " ");
            }
        }

        private static List<string> Union(ref string[] array1, ref string[] array2)
        {
            List<string> union = new List<string>();

            union.AddRange(array1);
            union.AddRange(array2);

            for (int i = 0; i < union.Count; i++)
            {
                for (int j = i + 1; j < union.Count; j++)
                {
                    if (union[i] == union[j])
                    {
                        union.RemoveAt(j);
                        j--;
                    }
                }
            }
            return union;
        }
    }
}
