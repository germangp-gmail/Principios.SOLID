using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado("Alicia", "Gerente", 5000);
            emp1.CalcularSalario();
            emp1.GuardarEnBaseDeDatos();
        }
    }
}