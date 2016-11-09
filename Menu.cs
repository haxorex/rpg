using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Menu
    {
        static void Main(string[] args)
        {
            Intro();
        }
        public static void Intro()
        {
            Console.WriteLine("Hello in the best(?).. WORST game ever..");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            List_Menu();
       }
        public static void List_Menu()
        {
            int menu;
            Console.WriteLine("-==SH!TTY RPG==-");
            Console.WriteLine("1. New Game.");
            Console.WriteLine("2. Exit.");
            menu = Convert.ToInt16(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Character.Create();
                    break;
                case 2:
                    Exit();
                    break;
                default:
                    Error();
                    List_Menu();
                    break;
            }
        }
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for playing! Hope you like our game.");
            Console.ReadLine();
        }
        public static void Error(){
            Console.Clear();
            Console.WriteLine("Something goes wrong.");
            Console.ReadLine();
        }
    }
}
