using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Weapon
    {
        //Member Variables (HAS A)
        Random rnd = new Random();
        public int weaponPower;
        public string weaponType;


        //Constructor
        public Weapon()
        {
            SetWeaponPower();
            weaponType = "Slashing";
        }
        //Methods

        public void SetWeaponPower()
        {
            weaponPower = rnd.Next(25, 76);
        }
        /*public void Attack()
        {
            //if statement?
            if (Weapon attackWithWeapon = true)
            {
                attackWithWeapon -= targetHealth;
                attackWithWeapon -= attackerEnergy;
                Console.WriteLine(targetAttacked + " has just been attacked for " + resultOfAttack + "!");
                Console.ReadLine();
            }

            // Weapon attackWithWeapon -= 
        }*/
    }
}
