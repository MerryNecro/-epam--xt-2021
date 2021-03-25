using System;
using System.Collections.Generic;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.Start();
        }

        public class Game
        {
            static readonly int width = 16;
            static readonly int heigh = 16;
            private Objects[,] map = new Objects[width,heigh];

            public void Start()
            {
                FillMap();
                PrintMap();
            }

            private void FillMap()
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < heigh; j++)
                    {
                        map[i, j] = new Empty(i, j);
                    }
                }

                Random random = new Random();
                for (int i = 0; i < 38; i++)
                {
                    int x = random.Next(0, width);
                    int y = random.Next(0, heigh);

                    if (i < 10) 
                    { 
                        map[x, y] = new Tree(x, y); 
                    }
                    else 
                    {
                        if (i < 20) 
                        { 
                            map[x, y] = new Wall(x, y); 
                        }
                        else if(i<30)
                        {
                            map[x, y] = new Lake(x, y);
                        }
                    }

                    if (i > 29 && i <34)//спавним врагов
                    {
                        map[x, y] = new Enemy(x, y);
                    }

                    if (i == 34)//спавним хилку
                    {
                        map[x, y] = new Health(x, y);
                    }

                    if (i == 35)//спавним ману
                    {
                        map[x, y] = new Mana(x, y);
                    }

                    if (i == 36)//спавним стамину
                    {
                        map[x, y] = new Stamina(x, y);
                    }

                    if (i == 37)
                    {
                        map[x, y] = new User(x, y);
                    }
                }
            }

            public void PrintMap()
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < heigh; j++)
                    {
                        map[i, j].Print();
                    }
                    Console.Write("*" + Environment.NewLine);
                }
                Console.WriteLine(new string('*', 17));
            }
        }
    }
}
