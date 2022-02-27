using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Text;

namespace Ny_mapp
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopWatch = new Stopwatch();
                
                
                List<int> numbers = new List<int>(); 

                Random rnd = new Random();
                int tal = 8000;

                for(int i= 0; i < tal; i++)
                    numbers.Add(rnd.Next(1, tal));

    
                stopWatch.Start();

                int temp;

                for (int j = 0; j <= numbers.Count - 2; j++) {
                    for (int i = 0; i <= numbers.Count - 2; i++) {
                        if (numbers[i] > numbers[i + 1]) {
                            temp= numbers[i + 1];
                            numbers[i + 1] = numbers[i];
                            numbers[i] = temp;
                        }
                    }
                }

                stopWatch.Stop();

                foreach (int a in numbers){
                Console.Write(a + " ");
                }

            

            Console.WriteLine("");
            Console.WriteLine("Det tog " + stopWatch.ElapsedMilliseconds + " Millisekunder");

        }
    }
}
