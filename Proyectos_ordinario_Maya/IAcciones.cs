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
        bool Agregar(int Id2, string marca2, string modelo2, int anio2, string color2, double precio2, string estado2);
        bool Actualizar(int Id, string marca, string modelo, int anio, string color, double precio, string estado);

        bool Eliminar(int Id3, string marca3, string modelo3, int anio3, string color3, double precio3, string estado3);

        bool ExportarExcel();

        bool Importar();
    }
}
