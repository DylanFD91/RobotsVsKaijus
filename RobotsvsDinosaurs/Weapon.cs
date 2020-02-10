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
        public int weaponPower;
        public string weaponType;
        public string weaponName;

        //Constructors
        public Weapon(string name, string type, int weaponPower)
        {
            weaponName = name;
            weaponType = type;
            this.weaponPower = weaponPower;
        }
        //Methods

    }
}
