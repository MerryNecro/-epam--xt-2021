using System;
using System.Collections.Generic;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\SomeDirectory";

            


            CastomGit a = new CastomGit(path);
            a.StartProgram();

            //List<(int, int)> lst = new List<(int, int)>();

        }
    }
}
