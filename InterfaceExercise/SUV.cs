using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public string make { get; set; } = "Toyota";
        public string model { get; set; } = "Sienna";
        public int year { get; set; } = 2010;
        public string driveTrain { get; set; } = "AWD";
        public bool isBuckleUp { get; set; } = true;


        public string name { get; set; } = "Auto Direct";
        public string slogan { get; set; } = "Drive your dreams";


        public string connectivity { get; set; }
        public int numOfPassangers { get; set; }


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