using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IReservacionAD
    {
        List<PA_recReservacion_Result> recReservaciones();

        PA_recReservacionXId_Result recReservacionesxid(int pId);

        bool insReservaciones(reservacione pobjReservacion);

        bool modReservaciones(reservacione pobjReservacion);

        bool delReservaciones(reservacione pobjReservacion);
    }
}
