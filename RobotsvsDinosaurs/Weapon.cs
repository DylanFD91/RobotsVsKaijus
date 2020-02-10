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

        //Constructors
        public Weapon()
        {
            SetWeaponPower();
            weaponType = "Slashing";
        }
        

        //Methods
        public void SetWeaponPower()
        {
            weaponPower = rnd.Next(50, 76);
        }
    }
}
