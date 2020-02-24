using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Weekend_Lab.Models
{
    public class DivideNum
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }


        public DivideNum()
        {

        }

        public int GetQuotient()
        {
            return Number1 / Number2;
            
        }

        public int GetRemainder()
        {
            return Number1 % Number2;
        }
    }
}
