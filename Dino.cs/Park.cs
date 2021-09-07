/* 
 * Author: Andy Lum
 * Date: 09/06/2021
 * File: Park.cs
 * Description: 
 * OS/IDE: Dell/C#
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino.cs
{
    class Park
    {
        private List<Dino> park;
        
        /* Description:
         *      Default constructor for Initialization of main.
         */
        public Park()
        {
            this.park = new List<Dino>();
        }
        static void Main(string[] args)
        {
            Park a = new Park();

            Console.WriteLine("Which option would you like to examine?");
            int choice = 0;
            Console.WriteLine("1. Add Dinos");
            Console.WriteLine("2. Print Info");
            Console.WriteLine("3. Make noise");
            Console.WriteLine("4. Age up");
            Console.WriteLine("5. Exit Program");

            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                /* Case 1: adding / creating a Dino.
                 */
                case 1: 
                    {
                        
                    }
                    break;
                /* Case 2: Printing info of Dino.
                */
                case 2:
                    {
                        for(int i = 0; i < a.park.Count(); i++)
                        {
                            a.park[i].printInfo();
                        
                        }
                        break;
                    }                 
                /* Case 3: printing noise of the Dino.
                */
                case 3:
                    {
                        for(int i = 0; i < a.park.Count(); i++)
                        {
                            a.park[i].makeNoise();
                        }
                        break;
                    }                  
                /* Case 4: age increasing.
                */
                case 4:
                    {
                        for(int i = 0; i < a.park.Count(); i++)
                        {
                            a.park[i].ageUp();
                        }
                        break;
                    }                    
                /* Case 5: Exit program.
                */
                case 5:
                    {
                        break;
                    }
            }
        }
    }
}
