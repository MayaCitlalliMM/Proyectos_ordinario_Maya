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
        void Agregar(int matricula, string nombre, int edad);
        void Eliminar(int matricula);
        void Actualizar(int matricula, string nombre, int edad);
        void ExportaraExcel();
        void Importar();
    }
}
