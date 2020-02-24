using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Weekend_Lab.Models
{
    public class AddNum
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int result { get; set; }





        public AddNum()
        {

        }

       

        public int AddNumbers()
        {
            return  Num1 + Num2;
            
        }


    }
}
