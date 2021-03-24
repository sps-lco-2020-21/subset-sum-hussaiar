using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSubsets
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] set = { "1", "2", "3", "4" };
            int required_value = 6;
            //generate all possible subsets.
            subsetsV2(set,6);
            Console.ReadKey();
        }

        static void subsetsV2(string[] list, int required_value)
        {
            int num = (int)Math.Pow(2, list.Length); 
            string[] result = new string[num]; 
            int sum=0;
            List<int> temp = new List<int> { };

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < list.Length; j++)  
                {
                    int t = (int)Math.Pow(2, j); 
                    if ((i & t) != 0) 
                                      
                    { result[i] += list[j]; } 
                }
                
            }
            foreach (string s in result)
            {
                string z = s;
                String.Concat(z.Where(c => !Char.IsWhiteSpace(c)));

                if (sum == required_value)
                {
                    Console.WriteLine("Subset is:");
                    foreach(int x in temp)
                    {
                        Console.WriteLine(x);
                    }
                }
                temp.Clear();
                foreach(char x in z)
                {
                    sum = sum + Convert.ToInt32(x);
                    temp.Add(x);
                }
                
            }
        }
    }
}
