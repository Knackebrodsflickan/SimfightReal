using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimfightReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to street fighter! Name your characters");
            Console.WriteLine("Character 1");
            String CharacterNameFirst = Console.ReadLine();

            Console.WriteLine("Character 2");
            String CharacterNameSecond = Console.ReadLine();
            Console.WriteLine("These are your characters: ");
            Console.WriteLine("Character 1: " + CharacterNameFirst);
            Console.WriteLine("Character 2: " + CharacterNameSecond);
            Console.ReadLine();

            hero h1 = new hero();
            Enemy e1 = new Enemy();

          //  Character c = new hero();
           // Character c2 = new Enemy();

            List<Character> alla = new List<Character>();
            alla.Add(h1);
            alla.Add(e1);

            //(hero)
            karaktär a = new karaktär();
            Ogre b = new Ogre();

            Console.WriteLine("Character hp  " + CharacterNameFirst + " " + a.hp);
            Console.WriteLine("Character hp  " + CharacterNameSecond + " " + b.hp);
            a.Attack(b);
            b.Attack(a);
            a.Attack(b);
            b.Attack(a);
            a.Attack(b);
            Console.WriteLine("This is how its going so far!");
            Console.WriteLine("Character hp  " + CharacterNameFirst + " " + a.hp);
            Console.WriteLine("Character hp  " + CharacterNameSecond + " " + b.hp);
            a.Attack(b);
            b.Attack(a);
            a.Attack(b);
            b.Attack(a);
            a.Attack(b);
            Console.WriteLine("Character hp  " + CharacterNameFirst + " " + a.hp);
            Console.WriteLine("Character hp  " + CharacterNameSecond + " " + b.hp);
            Console.ReadLine();

            if (a.hp < 0)
            {

                Console.WriteLine("Death to " + CharacterNameFirst);
                
               
                
            }
            else if(b.hp < 0)
            {
                Console.WriteLine("Death to " + CharacterNameSecond);
                Console.ReadLine();
            }
            




            weapon w = new weapon();
          //  weapon w = new CursedWeapon(); funkar också!. måste dock returnera samma dta typ

            //int monsterhp = 55;
          //  monsterhp -= w.Attack();


           // Console.WriteLine(monsterhp);

            Console.ReadLine();


           

        }
    }
}
