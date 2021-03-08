using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Array_Processing();
        }
        static void Array_Processing()
        {
            int temporary;
            int randomNumber;
            Random rand = new Random();
            List<int>  randArr= new List<int>();
            for(int i = 0; i < 30; i++)
            {
                randomNumber = rand.Next(-99, 99);
                randArr.Add(randomNumber);
            }
            Array_Sort(randArr);
            string mass = "";
            mass = string.Join(", ", randArr);
            Console.WriteLine(mass);
            Console.WriteLine("Min: " + randArr[0]);
            Console.WriteLine("Max: " + randArr[randArr.Count-1]);
        }

        static void Array_Sort(List<int> arrToSort)
        {
            int temp = 0;
            for(int i = 0; i < arrToSort.Count; i++)
            {
                for(int j = 0; j < arrToSort.Count - 1 - i; j++)
                {
                    if(arrToSort[j] > arrToSort[j + 1])
                    {
                        temp = arrToSort[j];
                        arrToSort[j] = arrToSort[j + 1];
                        arrToSort[j + 1] = temp;
                    }
                }
            }
            //return arrToSort;
        }
    }
}