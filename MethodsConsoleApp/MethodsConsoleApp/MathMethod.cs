using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsConsoleApp
{
    internal class MathMethod
    {
        //Create three methods that take one integer parameter and return an integer

        //Method 1
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }

        //Method 2
        public static int Defense(int defense)
        {
            int enemy_str = 7;
            int weapon_mt = 11;
            int triangle_Bonous = -1;
            int crit_coeff = 1;
            int damage = (enemy_str + (weapon_mt + triangle_Bonous) - defense) * crit_coeff;
            return damage;
        }


        //Method 3
        public static int Attack(int strength)
        {
            int enemy_def = 4;
            int weapon_mt = 8;
            int triangle_Bonus = 1;
            int crit_coeff = 3;
            int damage = (strength + (weapon_mt + triangle_Bonus) - enemy_def) * crit_coeff;
            return damage;
        }



    }
}
