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
        private DynamicArray<int> Humans;

        private int N;
        private int NumberOfHumanToDelete;

        public WeakestLink() {
            N = GetN();
            NumberOfHumanToDelete = GetNumberOfHumanToDelete();
            Humans = new DynamicArray<int>(N);

            for(int i = 0; i < N; i++)
            {
                Humans.Add(1);
            }

            Kick();
        }


        private void Kick() 
        {
            int TempCounter = 0;
            int Current = 0;
            int StageCounter = 1;

            while (true)
            {
                TempCounter++;
                
                if(TempCounter == NumberOfHumanToDelete)
                {
                    Humans.Remove(Humans[Current]);
                    Console.WriteLine("Раунд " + StageCounter + ". Вычеркнут человек. Людей осталось: " + Humans.Length);
                    StageCounter++;

                    if (NumberOfHumanToDelete > Humans.Length)
                    {
                        Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
                        break;
                    }

                    TempCounter = 1;
                }

                if(Current == Humans.Length - 1)
                {
                    Current = 0;
                }

                Current++;
            }
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


