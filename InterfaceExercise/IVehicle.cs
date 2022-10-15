using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string make { get; set; } 
        public string model { get; set; }
        public int year { get; set; }
        public string driveTrain { get; set; }

        public bool isBuckleUp { get; set; }

        public void Drive();
       


    }
}
