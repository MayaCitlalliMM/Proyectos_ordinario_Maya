using ClosedXML.Excel;
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

        public void Actualizar(int Id1, string marca, string modelo, int anio, string color, double precio, string estado)
        {
            try
            {
                var objetliminar = listaautos.Find(x => x.Id == Id1);

                if (objetliminar != null)
                {
                    listaautos.Remove(objetliminar);
                    listaautos.Add(new Auto(a.Id = Id1, a.Marca = marca, a.Modelo = modelo, a.Anio = anio, a.Color = color, a.Precio = precio, a.Estado = estado));
                }
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        public void Eliminar(int Id, string marca2, string modelo2, int anio2, string color2, double precio2, string estado2)
        {
            try
            {
                var objetoeliminar = listaautos.FirstOrDefault(x => x.Id == Id);
                if (objetoeliminar != null)
                    listaautos.Remove(objetoeliminar);
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        public bool ExportarExcel()
        {
            try
            {
                var rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var rutaArchivo = Path.Combine(rutaEscritorio, "Autos.xlsx");

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Autos");

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
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var filePath = Path.Combine(desktopPath, "Autos.xlsx"); // Usa "Autos.xlsx" si estás trabajando con autos

                if (!File.Exists(filePath))
                {
                    return false;
                }

                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet("Autos"); // Asegúrate de que la hoja se llame "Autos"
                    var rows = worksheet.RowsUsed().Skip(1); // Saltar encabezados

                    listaautos.Clear(); // Limpiar lista antes de importar

                    foreach (var row in rows)
                    {
                        int id = 0;
                        int.TryParse(row.Cell(1).Value.ToString(), out id);

                        string marca = row.Cell(2).Value.ToString();
                        string modelo = row.Cell(3).Value.ToString();

                        int anio = 0;
                        int.TryParse(row.Cell(4).Value.ToString(), out anio);

                        string color = row.Cell(5).Value.ToString();

                        double precio = 0;
                        double.TryParse(row.Cell(6).Value.ToString(), out precio);

                        string estado = row.Cell(7).Value.ToString();

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


        public void Eliminar(int matricula)
        {
            try
            {

                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        public void ExportaraExcel()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        public void Agregar(int matricula, string nombre, int edad)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        public void Actualizar(int matricula, string nombre, int edad)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        void IAcciones.Importar()
        {
            throw new NotImplementedException();
        }
    }
}
