using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("you have encountered Grozyni the Brigand and he laucnhes a surprise attack");
            Console.WriteLine("Input your defense stat:");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethod.Defense(defense);
            Console.WriteLine("You have taken " + enemy_damage + "HP of damage.");
            Console.WriteLine("Your healer, serra is near by. She heals you with her staff.");
            Console.WriteLine("Inout your healer's magic stat:");
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethod.Heal(magic);
            Console.WriteLine("You have been healed for " + hitpoints + "HP.");
            Console.WriteLine("Now it is your turn to counter attack.");
            Console.WriteLine("Input your strength stat:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethod.Attack(strength);
            Console.WriteLine("You have landed a critical attack and dealt " + damage + "HP worth of damage.");
            Console.ReadLine();
        }
    }
}
