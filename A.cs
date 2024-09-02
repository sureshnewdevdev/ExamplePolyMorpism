using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePolyMorpism
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UGStudent : Student
    {
        //public int Id { get; set; } 
        //public string Name { get; set; }

        public string Degree { get; set; }
    }

    public class ITStuduent : Student
    {
        public string ComputerSubject { get; set; }
    }
  

}
