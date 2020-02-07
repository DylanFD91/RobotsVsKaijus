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
        Weapon robotWeapon;
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;

        //Constructor
        public Robot()
        {
            robotName = RobotChoice();
            robotHealth = 100;
            robotPowerLevel = rnd.Next(20, 41);
            robotWeapon = new Weapon();
        }
        //Methods
        public string RobotChoice()//Names your robot
        {
            Console.WriteLine("What do you want your robot name to be");
            robotName = Console.ReadLine();
            return robotName;
        }
    }
}
