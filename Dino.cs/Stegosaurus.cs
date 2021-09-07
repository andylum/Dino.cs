/* 
 * Author: Andy Lum
 * Date: 09/06/2021
 * File: Stegosaurus.cs
 * Description: implementation of Stegosaurus. Program inherits from Dino to create the Stegosaurus.
 * OS/IDE: Dell/C#
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino.cs
{ 
    // calass definition. Inherits from Dino class.
    public class Stegosaurus : Dino
    {
        private string name; // mame of the Stegosaurus
        private int age; // age of the Stegosaurus
        private string noise; // noise of the Stegosaurus
        private int weight; // weight of the Stegosaurus

        /* Description:
         *      Default constructor used to create the Stegosaurus.
         */
        public Stegosaurus()
        {
            name = "Artemis";
            age = 45;
            noise = "MWMWRMWMR";
            weight = 1700;
        }
        /* Description:
         *      parameterized constructor for Stegosaurus.
         * Inputs:
         *      string name: name of the Stegosaurus
         *      int age: age of the Stegosaurus
         *      string noise: noise the Stegosaurus makes
         *      int weight: weight of the Stegosaurus
         */
        public Stegosaurus(string name, int age, string noise, int weight)
        {
            this.name = name;
            this.age = age;
            this.noise = noise;
            this.weight = weight;
        }
        /* Description: 
         *      function that prints out all of the data that is held inside the Stegosaurus class.
         *      
         * Results:
         *      printing Stegosaurus data.
         */
        public override void printInfo()
        {
            Console.WriteLine("Stegosaurus Name: " + name, "\n\tStegosaurus Age: " + age, "\n\tStegosaurus Noise: " + noise, "\n\tStegosaurus Weight: " + weight);
        }
        /* Description:
         *      function that prints the interesting noise of the Stegosaurus.
         */
        public override void makeNoise()
        {
            Console.WriteLine("This Stegosaurus has a happy noise: " + noise);
        }
        /* Description:
         *      function will increase the age of the Stegosaurus.
         * Results:
         *  age increasing by 1.
         */
        public override void ageUp()
        {
            age += 1;
        }
    }
    
}

    