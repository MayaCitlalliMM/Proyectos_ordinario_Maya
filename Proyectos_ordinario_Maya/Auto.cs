using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyectos_ordinario_Maya
{
    internal class Auto : Vehiculo
    {
        public Auto(int id, string marca, string modelo, int anio, string color, double precio, string estado)
        : base(id, marca, modelo, anio, color)
        {
            Precio = precio;
            Estado = estado;
        }

        public Auto() { }

        public double Precio { get; set; }
        public string Estado { get; set; }
    }
}
