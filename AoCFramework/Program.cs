using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoC_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<int>();
            var increases = 0;

            try
            {

                using (var file = new StreamReader("C:\\Users\\KB-PC\\OneDrive - Conestoga College\\Desktop\\input.txt"))
                {
                    var inputs = string.Empty;

                    while ((inputs = file.ReadLine()) != null)
                    {
                        inputList.Add(Convert.ToInt32(inputs));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            for (int i = 1; i < inputList.Count; i++)
            {
                if (inputList[i] > inputList[i - 1])
                {
                    increases++;
                }
            }

            Console.WriteLine(increases);
            Console.ReadKey();
        }
    }
}
