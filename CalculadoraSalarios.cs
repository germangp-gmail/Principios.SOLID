using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SOLID
{
    // Clase que se encarga de calcular el salario del empleado según el puesto
    public class CalculadoraSalarios
    {
        public decimal CalcularSalario(Empleado empleado)
        {
            if (empleado.Puesto == "Gerente")
            {
                return empleado.SalarioBase + 2000;
            }
            else if (empleado.Puesto == "Desarrollador")
            {
                return empleado.SalarioBase + 1000;
            }
            else if (empleado.Puesto == "Becario")
            {
                return empleado.SalarioBase + 500;
            }
            else
            {
                return empleado.SalarioBase;
            }
        }
    }
}