using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_ordinario_Maya
{
    internal interface IAcciones
    {
        List<Auto> MostrarAutos();
        bool Agregar(int Id, string marca2, string modelo2, int anio2, string color2, double precio2, string estado2);
        bool Actualizar(int Id, string marca2, string modelo2, int anio2, string color2, double precio2, string estado2);

        bool Eliminar(int Id, string marca2, string modelo2, int anio2, string color2, double precio2, string estado2);

        bool ExportarExcel();

        bool Importar();
    }
}
