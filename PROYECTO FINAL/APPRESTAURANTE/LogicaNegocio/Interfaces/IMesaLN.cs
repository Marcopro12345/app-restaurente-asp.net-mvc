using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IMesaLN
    {
        List<PA_recMesa_Result> recMesasln();

        PA_recMesaXId_Result recMesasXIdln(int pId);

        bool insMesasln(mesa pobjMesa);

        bool modMesasln(mesa pobjMesa);

        bool delmesasln(mesa pobjMesa);

    }
}
