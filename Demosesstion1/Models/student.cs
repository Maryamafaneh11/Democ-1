using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demosesstion1.Models
{
     public abstract class student
    {
       protected int id;
        protected string name;
        protected DateTime bday;

        public  int _id
        {
            set { id = value; }
            get { return id; }
        }

        public string _name
        {
            set { name = value; }
            get { return name; }
        }

        public DateTime _bday
        {
            set { bday = value; }
            get { return bday; }
        }
        public abstract bool check();

        public abstract double calc();
       

        public string print(double avg)
        {
            string messg = "student" + name + "has avg" + avg;
            return messg;
        }
    }
}
