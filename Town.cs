using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Town
    {
        public string place_name;
        public static void TownInfo()
        {
            Console.Clear();
            Character.Informations();
            Town_Menu();
        }
        public static void Town_Menu()
        {
            int choice;
            Console.WriteLine("=====TOWN=====");
            Console.WriteLine("1. Hospital");
            Console.WriteLine("2. Yard");
            Console.WriteLine("3. Gyp");
            choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Szpital
                    Hospital();
                    break;
                case 2:
                    // Dziedziniec
                    Yard();
                    break;
                case 3:
                    //kanciarz
                    break;
                default:
                    Menu.Error();
                    break;

            }

        }
        public static void Hospital()
        {
            Console.Clear();
            Character.Informations();
            Console.WriteLine("===HOSPITAL===");
            Console.WriteLine("Welcome in hospital, here you can treat yourself.");
            Console.WriteLine("Untill 5 level it will be free, but after you will have to pay.");
            Console.WriteLine("Leave the hospital (press any key..).");
            Console.ReadLine();
            TownInfo();
        }
        public static void Yard()
        {
            Console.Clear();
            Character.Informations();
            Console.WriteLine("=====YARD=====");
            Console.WriteLine("Welcome to yard, here you can train yourself for money.");
            Console.WriteLine("Leave the yard (press any key..).");
            Console.ReadLine();
            TownInfo();
        }
    }
}
