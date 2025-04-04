using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IClienteLN
    {
        List<PA_recCliente_Result> recClientesln();

        PA_recClienteXId_Result recClientesXIdln(int pId);

        bool insClienteln(cliente pobjCliente);

        bool modClienteln(cliente pobjCliente);

        bool delClienteln(cliente pobjCliente);
    }
}
