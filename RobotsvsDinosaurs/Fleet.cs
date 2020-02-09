using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Fleet
    {
        //Member Variables
        //Constructor
        //Methods

        public List<Robot> robots = new List<Robot>();
        public Fleet()
        {
            for (int index = 0; index < 3; index++)
            {
                Robot robo = new Robot();
                robots.Add(robo);
            }
            PrintRobotFleet(robots);
        }
        public void PrintRobotFleet(List<Robot> robotNames)
        {
            foreach (Robot robot in robotNames)
            {
                Console.WriteLine("\nYour Robots Name is: " + robot.robotName);
                Console.WriteLine("Your Robots Health is: " + robot.robotHealth);
                Console.WriteLine("Your Robots Energy is: " + robot.robotPowerLevel);
                Console.WriteLine("Your Robots Weapon is: " + robot.robotWeaponType);
                Console.WriteLine("Your Robots Weapon Power is: " + robot.robotWeapon.weaponPower + " and the type is " + robot.robotWeapon.weaponType);
            }
        }
    }
}
