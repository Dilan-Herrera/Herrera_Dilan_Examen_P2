using Herrera_Dilan_Examen_P2.Interfaces;
using Herrera_Dilan_Examen_P2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera_Dilan_Examen_P2.Repositories
{
    internal class RecargasFilesRepository : IRecargaRepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "HerreraDilan.txt");

        public bool CrearRecarga(Recarga recarga)
        {
            try
            {
                string linea = $"{recarga.Nombre}|{recarga.Numero}";
                File.AppendAllText(_fileName, linea + Environment.NewLine);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Recarga ObtenerUltimaRecarga()
        {
            try
            {
                if (File.Exists(_fileName))
                {
                    var lineas = File.ReadAllLines(_fileName);
                    if (lineas.Length > 0)
                    {
                        var ultimaLinea = lineas.Last();
                        var datos = ultimaLinea.Split('|');
                        if (datos.Length == 2)
                        {
                            return new Recarga
                            {
                                Nombre = datos[0],
                                Numero = datos[1]
                            };
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return null;
        }
        public string ObtenerUltimaRecargaFormateada()
        {
            var ultimaRecarga = ObtenerUltimaRecarga();
            if (ultimaRecarga != null)
            {
                return $"Nombre: {ultimaRecarga.Nombre}\nNúmero: {ultimaRecarga.Numero}";
            }
            return "No hay recargas registradas.";
        }
    }
}
