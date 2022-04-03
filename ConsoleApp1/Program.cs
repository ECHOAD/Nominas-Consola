using ConsoleApp1;
using System;


namespace Sistema_de_Nomina
{
    internal class Program
    {


        static void Main(string[] args)
        {

            int cantidad_empleado;

            Empleados[] arreglo_empleados;


            do
            {
                cantidad_empleado = InputHelper.GetInputInt("Ingrese la cantidad de salarios a calcular: ");

            }
            while (cantidad_empleado < 0);

            arreglo_empleados = new Empleados[cantidad_empleado];


            for (int i = 0; i < cantidad_empleado; i++)
            {
                Empleados empleado_actual = new Empleados();

                empleado_actual.NombreCompleto = InputHelper.GetInputString("Digite el nombre Completo: ");
                empleado_actual.SueldoBruto = InputHelper.GetInputDouble("Digite el sueldo bruto: ");
                empleado_actual.CalcularSueldoNeto();


                arreglo_empleados[i] = empleado_actual;

            }

            Console.WriteLine("El total de empleado es: " + arreglo_empleados.Length);



            for (int i = 0; i < arreglo_empleados.Length; i++)
            {
                Empleados empleado_actual = arreglo_empleados[i];


                Console.WriteLine("Nombre: " + empleado_actual.NombreCompleto);
                Console.WriteLine("Sueldo Bruto: " + empleado_actual.SueldoBruto);
                Console.WriteLine("El total de SFS es: " + DeduccionHelper.CalcularSfs(empleado_actual.SueldoBruto).ToString("##"));
                Console.WriteLine("El total de AFP es: " + DeduccionHelper.CalcularAfp(empleado_actual.SueldoBruto).ToString("##"));
                Console.WriteLine("El total de ISR es: " + DeduccionHelper.CalcularIsr(empleado_actual.SueldoBruto).ToString("##"));
                Console.WriteLine("El total de Salarios Netos es: " + empleado_actual.GetSueldoNeto() + "\n\n");


            }


            Console.ReadKey();

        }

    }
}