using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public string make { get; set; } = "Buick";
        public string model { get; set; } = "Century";
        public int year { get; set; } = 2000;
        public string driveTrain { get; set; } = "FWD";
        public bool isBuckleUp { get; set; } = true;


        public string name { get; set; } = "Quality Motors";
        public string slogan { get; set; } = "Quality you can feel";


        public string suspension { get; set; } = "Multi-Link";
        public string transmission { get; set; } = "Manual";

        
        public void Drive()
        {      
            if (isBuckleUp == true)
            {
                
                Console.WriteLine($"{GetType().Name}'s seat belt is ON. Now it is safe to drive!");
                isBuckleUp = false; 
                
            }
            else
            {
                Console.WriteLine($"{GetType().Name}'s seat belt is OFF. Can't drive until you buckle up!");
               
            }
        }

        
    }
}
