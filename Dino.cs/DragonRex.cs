/* 
 * Author: Andy Lum
 * Date: 09/06/2021
 * File: DragonRex.cs
 * Description: implementation of Stegosaurus. Program inherits from Dino to create the DragonRex.
 * OS/IDE: Dell/C#
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino.cs
{
    // class definition. Inherits from Dino class.
    class DragonRex : Dino
    {
        private string name; // name of the DragonRex.
        private int age; // age of the DragonRex.
        private string noise; // noise of the DragonRex.
        private int weight; // weight of the DragonRex.

        /* Description:
         *      default constructor used to create the DragonRex.
         */
        public DragonRex()
        {
            name = "Apophis";
            age = 2100;
            noise = "ROOOOOOOOOOOOARAARARAAR";
            weight = 3000;
        }
        /* Description:
         *      parameterized constructor for DragonRex.
         * Inputs:
         *      string name: name of the DragonRex.
         *      int age: age of the DragonRex.
         *      string noise: noise the DragonRex makes.
         *      int weight: weight of the DragonRex.
         */
        public DragonRex(string name, int age, string noise, int weight)
        {
            this.name = name;
            this.age = age;
            this.noise = noise;
            this.weight = weight;
        }
        /* Description: 
         *      function that prints out all of the data that is held inside the DragonRex class.
         *      
         * Results:
         *      printing DragonRex data.
         */
        public override void printInfo()
        {
            Console.WriteLine("DragonRex name: " + name, "\n\tDragonRex age: " + age, "\n\tDragonRex noise: " + noise, "\n\tDragonRex weight: " + weight);
        }
        /* Description:
         *      function that prints the interesting noise of the DragonRex.
         */
        public override void makeNoise()
        {
            Console.WriteLine("This DragonRex has a intresting noise: " + noise);
        }
        /* Description:
         *      function will increase the age of the DragonRex.
         * Results:
         *  age increasing by 1.
         */
        public override void ageUp()
        {
            age += 1;
        }
    }
}
