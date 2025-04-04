using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IClienteAD
    {
        List<PA_recCliente_Result> recClientes();

        PA_recClienteXId_Result recClientesxid(int pId);

        bool insClientes(cliente pobjCliente);

        bool modClientes(cliente pobjCliente);

        bool delClientes(cliente pobjCliente);
    }
}
