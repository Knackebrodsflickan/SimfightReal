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

            Character c = new hero();
            Character c2 = new Enemy();

            List<Character> alla = new List<Character>();
            alla.Add(h1);
            alla.Add(e1);

            //(hero)



            Console.WriteLine(h1.name);
            Console.ReadLine();

        }
    }
}
