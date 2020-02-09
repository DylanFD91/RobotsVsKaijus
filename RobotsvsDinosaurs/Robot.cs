using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Robot
    {
        //Member Variables
        Random rnd = new Random();
        public Weapon robotWeapon;
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public string robotWeaponType;

        //Constructor
        public Robot()
        {
            RobotChoice();
            robotHealth = rnd.Next(70, 126);
            robotPowerLevel = rnd.Next(20, 41);
            robotWeaponType = "Plasma Sword";
            robotWeapon = new Weapon();
        }
        //Methods
        public void RobotChoice()//Names your robot
        {
            Console.WriteLine("\nWhat do you want your robot name to be");
            robotName = Console.ReadLine();
        }
        public void RobotAttack()
        {

        }
    }
}
