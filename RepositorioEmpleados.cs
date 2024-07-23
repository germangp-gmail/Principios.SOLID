using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Clase que maneja la persistencia de los datos del empleado en la base de datos
    public class RepositorioEmpleados
    {
        public void GuardarEnBaseDeDatos(Empleado empleado)
        {
            Console.WriteLine($"Guardando {empleado.Nombre} en la base de datos...");
            // Código para guardar el empleado en la base de datos
        }
    }
}