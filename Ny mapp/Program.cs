using System;
using System.Collections.Generic;

namespace Ny_mapp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); 

            Random rnd = new Random();

            for(int i= 0; i < 1000000; i++)
                numbers.Add(rnd.Next(1, 1000000));
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

            foreach (int a in numbers){
            Console.Write(a + " ");
            }

        }
    }
}
