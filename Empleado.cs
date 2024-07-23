using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado(string nombre, string puesto, decimal salarioBase)
        {
            Nombre = nombre;
            Puesto = puesto;
            SalarioBase = salarioBase;
        }

        public void CalcularSalario()
        {
            if (Puesto == "Gerente")
            {
                Console.WriteLine($"El salario de {Nombre} es {SalarioBase + 2000}");
            }
            else if (Puesto == "Desarrollador")
            {
                Console.WriteLine($"El salario de {Nombre} es {SalarioBase + 1000}");
            }
            else if (Puesto == "Becario")
            {
                Console.WriteLine($"El salario de {Nombre} es {SalarioBase + 500}");
            }
            else
            {
                Console.WriteLine($"El salario de {Nombre} es {SalarioBase}");
            }
        }

        public void GuardarEnBaseDeDatos()
        {
            Console.WriteLine($"Guardando {Nombre} en la base de datos...");
            // Código para guardar el empleado en la base de datos
        }
    }
}
