using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Character
    {
        public static int hp;
        public static double dmg;
        public static int lvl;
        public static void Create()
        {
            Console.Clear();
            Postac.MakeCharacter();
        }
        public static void Informations()
        {
         Postac postac = new Postac();
            postac.level = 1;
            string prof;
            int base_dmg;
            int base_hp;
            lvl = postac.level;
            prof = Postac.pick;
            base_dmg = Postac.dmg;
            base_hp = Postac.hp;
            hp = base_hp + (10 * lvl);
            dmg = base_dmg + (0.5 * lvl);
            Console.WriteLine("=====INFO=====");
            Console.WriteLine("Nickname: {0}", Postac.player_name);
            Console.WriteLine("Class: {0}", prof);
            Console.WriteLine("Level: {0}", lvl);
            Console.WriteLine("HP: {0}", hp);
            Console.WriteLine("DMG: {0}", dmg);
            Console.WriteLine("==============");
        }
    }
}

