using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class UserCommunication
    {
        public void OpenMenu(CastomGit git, String SelectedStr)
        {
            Menu selected;

            while(!Enum.TryParse(SelectedStr, out selected)) { }

            switch (selected)
            {
                case Menu.Track:
                    git.Tracking();
                    break;
                case Menu.RollBack:
                    Console.WriteLine("Enter dateTime to roll back:");
                    DateTime dateTime;
                    DateTime.TryParse(Console.ReadLine(), out dateTime);
                    git.RollDown(dateTime);
                    break;
                case Menu.RollUp:
                    Console.WriteLine("Enter dateTime to roll up:");
                    DateTime.TryParse(Console.ReadLine(), out dateTime);
                    git.RollUp(dateTime);
                    break;
                case Menu.End:
                    Console.WriteLine("End");
                    break;
                default:
                    Console.WriteLine("def sel");
                    break;
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("What are you need?"
                + Environment.NewLine + "   Track" 
                + Environment.NewLine + "   RollBack" 
                + Environment.NewLine + "   RollUp");
        }
    }

    enum Menu
    {
        Track = 0,
        RollBack = 1,
        RollUp = 2,
        End = 3
    }
}
