using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IReservacionLN
    {
        List<PA_recReservacion_Result> recReservacionesln();

        PA_recReservacionXId_Result recReservacionesXIdln(int pId);

        bool insReservacionln(reservacione pobjReservacion);

        bool modReservacionln(reservacione pobjReservacion);

        bool delReservacionln(reservacione pobjReservacion);

    }
}
