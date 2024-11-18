using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory factory = new CharacterFactory();

            Character warrior1 = factory.GetCharacter("Tom", "Warrior", "warrior.png");
            Character warrior2 = factory.GetCharacter("Tom", "Warrior", "warrior.png"); 
            Character mage = factory.GetCharacter("Robert", "Mage", "mage.png");
            Character warrior3 = factory.GetCharacter("Won", "Warrior", "warrior.png");


            warrior1.Level = 5;
            warrior1.Experience = 1000;

            Console.WriteLine($"\nInformation about characters:");
            Console.WriteLine(warrior1);
            Console.WriteLine(warrior2); 
            Console.WriteLine(mage);
            Console.WriteLine(warrior3);

            Console.Read();
        }
    }
}
