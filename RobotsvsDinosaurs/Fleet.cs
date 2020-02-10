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
        public List<Robot> robots = new List<Robot>();//fleet list storage(Complete)

        //Constructor
        public Fleet()//creates the fleet(Complete)
        {
            for (int index = 0; index < 3; index++)
            {
                Robot robo = new Robot();
                robots.Add(robo);
            }
            Console.WriteLine("-----------------------");
            PrintRobotFleet(robots);
        }

        //Methods
        public void PrintRobotFleet(List<Robot> robotNames)//prints the fleet info(Complete)
        {
            foreach (Robot robot in robotNames)
            {
                Console.WriteLine("\n\nYour Robots Name is: " + robot.robotName + " Here is his statistics: ");
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("Your Robots Health is: " + robot.robotHealth);
                Console.WriteLine("Your Robots Energy is: " + robot.robotPowerLevel);
                Console.WriteLine("Your Robots Weapon is: " + robot.robotWeaponType);
                Console.WriteLine("Your Robots Weapon Power is: " + robot.robotWeapon.weaponPower + " and the type is " + robot.robotWeapon.weaponType);
            }
        }
    }
}