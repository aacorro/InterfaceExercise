using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public string make { get; set; } = "Chevrolet";
        public string model { get; set; } = "Silverado";
        public int year { get; set; } = 2001;
        public string driveTrain { get; set; } = "4-WD";
        public bool isBuckleUp { get; set; }


        public string name { get; set; } = "Auto Direct";
        public string slogan { get; set; } = "Drive your dreams";


        public int payloadCapacity { get; set; } = 3000;
        public int towingCapacity { get; set; } = 10000;

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