using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demosesstion1.Models;
namespace Demosesstion1.Models
{
    public  class Universitystudent : student
    {
        
        double mark1;
        double mark2;

        int hour1;
        int hour2;


        public double _mark1
        {
            set { mark1 = value; }
            get { return mark1; }
        }


        public double _mark2
        {
            set { mark2 = value; }
            get { return mark2; }
        }

        public int _hour1
        {
            set { hour1 = value; }
            get { return hour1; }
        }

        public int _hour2
        {
            set { hour2 = value; }
            get { return hour1; }
        }


        public override bool check()
        {
            if (id != 0 && name != "" && mark1 != 0 && mark2 != 0 && bday.ToString() != "00/00/0001" && mark1 != 0 && mark2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        

        public override double calc()
        {
            double avg = ((mark1 * hour1)+(mark2 * hour2))/(hour1+hour2);
            return avg;
        }
        

    }
}



