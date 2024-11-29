using Herrera_Dilan_Examen_P2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera_Dilan_Examen_P2.Interfaces
{
    public interface IRecargaRepository
    {
        Recarga ObtenerUltimaRecarga();
        Boolean CrearRecarga(Recarga recarga);
    }
}
