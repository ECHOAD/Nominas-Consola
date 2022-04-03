using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DeduccionHelper
    {

        public static double CalcularAfp(double sueldoBruto)
        {

            return   (sueldoBruto* .10) ;
        }

        public static double CalcularSfs(double sueldoBruto)
        {

            return  (sueldoBruto * .07);
        }


        public static double CalcularIsr(double sueldoBruto)
        {

            return  (sueldoBruto * .02);
        }
    }
}
