using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IMesaAD
    {
        List<PA_recMesa_Result> recMesas();

        PA_recMesaXId_Result recMesasxid(int pId);

        bool insMesas(mesa pobjMesa);

        bool modMesas(mesa pobjMesa);

        bool delMesas(mesa pobjMesa);
    }
}
