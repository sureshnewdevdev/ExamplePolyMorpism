using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePolyMorpism
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CreditAccount : Account 
    {
        public int CreditLimt { get; set; }
    }
}
