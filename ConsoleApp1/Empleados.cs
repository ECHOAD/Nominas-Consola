using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Empleados
    {

        public Empleados(string nombre, double sueldoBruto)
        {

        }

        public Empleados()
        {

        }

        public string NombreCompleto { get; set; }

        public double SueldoBruto { get; set; }

        private  double _sueldoNeto;



        public double GetMontoAnual()
        {
            return SueldoBruto * 12;
        }

        public void CalcularSueldoNeto()
        {
            double total_deducciones = DeduccionHelper.CalcularAfp(this.SueldoBruto)
                + DeduccionHelper.CalcularIsr(this.SueldoBruto)
                + DeduccionHelper.CalcularSfs(this.SueldoBruto);


            this._sueldoNeto = SueldoBruto - total_deducciones;
        }

        public double GetSueldoNeto()
        {
           return _sueldoNeto;
        }

    }
}
