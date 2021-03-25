using System;
using System.Collections.Generic;

namespace _2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingArea drawing = new DrawingArea();
            drawing.Start();
        }
        
    }

    public class DrawingArea
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private User currentUser;
        AddHelper helper = AddHelper.GetHelper();
        public void Start()
        {
            AddUser();
            Menu();
        }
            
        public void Menu()
        {
            Console.WriteLine(currentUser.name + ", what you want to do?");
            Console.WriteLine("    1) Add new user");
            Console.WriteLine("    2) Change current user");
            Console.WriteLine("    3) Add new figure");
            Console.WriteLine("    4) Print all figures");
            Console.WriteLine("    5) Delete all figures");
            Console.WriteLine("    6) Exit");

            switch (IntValue())
            {
                case 1:
                    AddUser();
                    Menu();
                    break;
                case 2:
                    ChangeUser();
                    Menu();
                    break;
                case 3:
                    currentUser.AddFigure(helper.AddFigure(currentUser.name));
                    Menu();
                    break;
                case 4:
                    currentUser.WriteAllFigures();
                    Menu();
                    break;
                case 5:
                    currentUser.DeleteAllFigures();
                    Menu();
                    break;
                case 6:
                    break;
                default:
                    Menu();
                    break;
            }
        }

        private void AddUser()
        {
            string name = "";
            while (name == "")
            {
                Console.Clear();
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
                if (users.ContainsKey(name))
                {
                    name = "";
                    Console.WriteLine("User with this name already exists");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            currentUser = new User(name);
            users.Add(name, currentUser);
        }

        public void ChangeUser()
        {
            string name = "";
            while (name == "")
            {
                Console.Clear();
                Console.WriteLine("Enter user's name: ");
                name = Console.ReadLine();
                if (!users.ContainsKey(name))
                {
                    name = "";
                    Console.WriteLine("User with this name wasn't found");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            currentUser = users[name];
        }


        public static int IntValue()
        {
            int result = 0;
            bool isDone = int.TryParse(Console.ReadLine(), out result);
            while (!isDone)
            {
                Console.WriteLine("Wrong value, try again");
                isDone = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }
    }
}
