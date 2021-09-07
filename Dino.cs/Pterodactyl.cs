/* 
 * Author: Andy Lum
 * Date: 09/06/2021
 * File: Pterodactyl.cs
 * Description: implementation of Pterodactyl. Program inherits from Dino to create the Pterodactyl.
 * OS/IDE: Dell/C#
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino.cs
{
    // class definition. Inherits from Dino Class.
    class Pterodactyl : Dino
    {
        private string name; // name of the Pterodactyl.
        private int age; // age of the Pterodactyl.
        private string noise; // noise of the Pterodactyl.
        private int weight; // weight of the Pterodactyl.

        /* Description:
         *      default constructor used to create the Pterodactyl.
         */
        public Pterodactyl()
        {
            name = "Munchie";
            age = 50;
            noise = "ATRRCHHHTTTCCHH";
            weight = 1000;
        }
        /* Description:
         *      parameterized constructor for Pterodactyl.
         * Inputs:
         *      string name: name of the Pterodactyl.
         *      int age: age of the Pterodactyl.
         *      string noise: noise the Pterodactyl makes.
         *      int weight: weight of the Pterodactyl.
         */
        public Pterodactyl(string name, int age, string noise, int weight)
        {
            this.name = name;
            this.age = age;
            this.noise = noise;
            this.weight = weight;
        }
        /* Description: 
         *      function that prints out all of the data that is held inside the Pterodactyl class.
         *      
         * Results:
         *      printing Pterodactyl data.
         */
        public override void printInfo()
        {
            Console.WriteLine("Pterodactyl Name: " + name, "\n\tPterodactyl age: " + age, "\n\tPterodactyl noise: " + noise, "\n\tPterodactyl weight: " + weight);
        }
        /* Description:
         *      function that prints the interesting noise of the Pterodactyl.
         */
        public override void makeNoise()
        {
            Console.WriteLine("This Pterodactyl has a unique noise: " + noise);
        }
        /* Description:
         *      function will increase the age of the Pterodactyl.
         * Results:
         *  age increasing by 1.
         */
        public override void ageUp()
        {
            age += 1;
        }
    }
}
