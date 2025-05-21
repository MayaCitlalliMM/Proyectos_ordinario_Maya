using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_ordinario_Maya
{
    internal class Acciones : IAcciones
    {
        Auto a = new Auto();
        private List<Auto> listaautos = new List<Auto>()
        {
            new Auto(1,"Tesla","Model 3",2025,"Rojo",500000,"Disponible")
        };

        Correo correo = new Correo();

        public List<Auto> MostrarAutos()
        {
            try
            {
                return listaautos;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        public bool Actualizar(int Id, string marca, string modelo, int anio, string color, double precio, string estado)
        {
            try
            {
                var objetliminar = listaautos.Find(x => x.Id == Id);

                if (objetliminar != null)
                {
                    listaautos.Remove(objetliminar);
                    listaautos.Add(new Auto(Id, marca, modelo, anio, color, precio, estado));
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }


     


        public bool ExportarExcel()
        {
            try
            {
                var rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var rutaArchivo = Path.Combine(rutaEscritorio, "Autos_Exportado.xlsx");

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Encabezados
                    worksheet.Cell(1, 1).Value = "ID";
                    worksheet.Cell(1, 2).Value = "Marca";
                    worksheet.Cell(1, 3).Value = "Modelo";
                    worksheet.Cell(1, 4).Value = "Año";
                    worksheet.Cell(1, 5).Value = "Color";
                    worksheet.Cell(1, 6).Value = "Precio";
                    worksheet.Cell(1, 7).Value = "Estado";

                    // Datos
                    for (int i = 0; i < listaautos.Count; i++)
                    {
                        var aut = listaautos[i];
                        worksheet.Cell(i + 2, 1).Value = aut.Id;
                        worksheet.Cell(i + 2, 2).Value = aut.Marca;
                        worksheet.Cell(i + 2, 3).Value = aut.Modelo;
                        worksheet.Cell(i + 2, 4).Value = aut.Anio;
                        worksheet.Cell(i + 2, 5).Value = aut.Color;
                        worksheet.Cell(i + 2, 6).Value = aut.Precio;
                        worksheet.Cell(i + 2, 7).Value = aut.Estado;
                    }

                    workbook.SaveAs(rutaArchivo);
                }

                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }
        public bool Importar()
        {
            try
            {
                var downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                var filePath = Path.Combine(downloadsPath, "Autos_Importacion.xlsx");

                if (!File.Exists(filePath))
                {
                    return false;
                }

                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet("Sheet1");
                    var rows = worksheet.RowsUsed().Skip(1); // Saltar encabezado

                    listaautos.Clear(); // Limpia la lista antes de importar

                    foreach (var row in rows)
                    {
                        int id = int.Parse(row.Cell(1).GetValue<string>());
                        string marca = row.Cell(2).GetValue<string>();
                        string modelo = row.Cell(3).GetValue<string>();
                        int anio = int.Parse(row.Cell(4).GetValue<string>());
                        string color = row.Cell(5).GetValue<string>();
                        double precio = double.Parse(row.Cell(6).GetValue<string>());
                        string estado = row.Cell(7).GetValue<string>();

                        listaautos.Add(new Auto(id, marca, modelo, anio, color, precio, estado));
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        

        public bool Agregar(int Id2, string marca2, string modelo2, int anio2, string color2, double precio2, string estado2)
        {
            try
            {
                listaautos.Add(new Auto(Id2, marca2, modelo2, anio2, color2, precio2, estado2));
                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                var autoAEliminar = listaautos.FirstOrDefault(x => x.Id == id);
                if (autoAEliminar != null)
                {
                    listaautos.Remove(autoAEliminar);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

    }
}
