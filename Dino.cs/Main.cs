/* 
 * Author: Andy Lum
 * Date: 09/06/2021
 * File: Main.cs
 * Description: Base class for Dino. Program creating a default dino name, age, noise, and weight.
 * OS/IDE: Dell/C#
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino.cs
{
   
    public abstract class Dino
    {
        private string name; // name of the dino.
        private int age; // age of the dino.
        private string noise; // noise the dino makes.
        private int weight; // weight of the dino.

        /* Description:
         *      default constructor used to create the Stegosaurus, Pterodactyl, and DragonRex class.
         * 
         */
        public Dino()
        {
            name = "Milo";
            age = 10;
            noise = "GRRRARAAR";
            weight = 100;
        }
        /* Description:
         *      parameterized constructor for Dino.
         * Inputs:
         *      string name : name of the dino.
         *      int age: age of the dino.
         *      string noise: noise of the dino.
         *      int weight: weight of the dino.
         * 
         */
        public Dino(string name, int age, string noise, int weight)
        {
            this.name = name;
            this.age = age;
            this.noise = noise;
            this.weight = weight;
        }
        /* Description: 
         *      function that prints out all of the data that is held inside the dino class.
         *      
         * Results:
         *      printing dino data.
         */
        public virtual void printInfo()
        {
            Console.WriteLine("Dino Name: " + name, "\n\tDino Age: " + age, "\n\tDino noise: " + noise, "\n\tDino weight: " + weight);
        }
        /* Description:
         *      function that prints the interesting noise of the dino.
         */
        public virtual void makeNoise()
        {
            Console.WriteLine("This Dino has a happy noise: " + noise + ".");
        }
        /* Description:
         *      function will increase the age of the dino.
         * Results:
         *  age increasing by 1.
         */
        public virtual void ageUp()
        {
            age += 1;
        }

    }
}
