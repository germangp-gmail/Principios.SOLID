using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Clase que maneja únicamente la información del empleado
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
    }
}