using _3_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class WeakestLink
    {
        private CycledDynamicArray<int> Humans;

        private int N;
        private int NumberOfHumanToDelete;

        public WeakestLink() {
            N = GetN();
            NumberOfHumanToDelete = GetNumberOfHumanToDelete();
            Humans = new CycledDynamicArray<int>(N);
            for(int i = 0; i < N; i++)
            {
                
            }
            Kick();
        }


        private void Kick() 
        {


        }


        private int GetN()
        {
            int result;
            Console.Write("Enter N: ");
            do
            {
                if(int.TryParse(Console.ReadLine(), out result))
                {
                    if (result <= 0)
                    {
                        Console.WriteLine("Number of people can't be < or = 0");
                    }
                    else
                    {
                        return result;
                    }
                }
                Console.Write("Something is wrong. Try again: ");

            } while (true);
        }


        private int GetNumberOfHumanToDelete()
        {
            int result;
            Console.Write("Enter number of person to kick: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result <= 0 || result > N)
                    {
                        Console.WriteLine("Number of people can't be <= 0 or > N");
                    }
                    else
                    {
                        return result;
                    }
                }
                Console.Write("Something is wrong. Try again: ");

            } while (true);
        }



    }
}


