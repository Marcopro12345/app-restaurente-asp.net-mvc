using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion
{
    public class ClienteLN : IClienteLN
    {
        public static RTEntities _gobjContextoRT= new RTEntities();
        private readonly IClienteAD _objClienteAD = new ClienteAD(_gobjContextoRT);

        public List<PA_recCliente_Result> recClientesln()
        {
            List<PA_recCliente_Result> lobjRespuesta = new List<PA_recCliente_Result>();
            try
            {
                lobjRespuesta = _objClienteAD.recClientes();
            }
            catch (Exception ex)                                    
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public PA_recClienteXId_Result recClientesXIdln(int pId)
        {
            PA_recClienteXId_Result objRespuesta = new PA_recClienteXId_Result();
            try
            {
                objRespuesta = _objClienteAD.recClientesxid(pId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }

        public bool insClienteln(cliente pobjCliente)
        {
            bool objRespuesta = new bool();
            
            try
            {
                objRespuesta = _objClienteAD.insClientes(pobjCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return objRespuesta;
        }

        public bool modClienteln(cliente pobjCliente)
        {
            bool objRespuesta = new bool();

            try
            {
                objRespuesta = _objClienteAD.modClientes(pobjCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRespuesta;
        }

        public bool delClienteln(cliente pobjCliente)
        {
            bool objRespuesta = new bool();

            try
            {
                objRespuesta = _objClienteAD.delClientes(pobjCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRespuesta;
        }
    }
}
