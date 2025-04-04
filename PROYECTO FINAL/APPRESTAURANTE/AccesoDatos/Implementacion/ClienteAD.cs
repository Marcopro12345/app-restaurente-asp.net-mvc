using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class ClienteAD : IClienteAD
    {
        private RTEntities gobjContextoRT;

        public ClienteAD(RTEntities _gobjContexto)
        {
            this.gobjContextoRT = _gobjContexto;
        }

        public List<PA_recCliente_Result> recClientes()
        {
            List<PA_recCliente_Result> lobjRespuesta = new List<PA_recCliente_Result>();

            try
            {
                lobjRespuesta = gobjContextoRT.PA_recCliente().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
        //llamar por id

        public PA_recClienteXId_Result recClientesxid(int pId)
        {
            PA_recClienteXId_Result objRespuesta = new PA_recClienteXId_Result();

            try
            {
                objRespuesta = gobjContextoRT.PA_recClienteXId(pId).Single();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }
        public bool insClientes(cliente pobjCliente)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;

            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;

                intVal = gobjContextoRT.PA_insCliente(pobjCliente.nombre, pobjCliente.apellidos, pobjCliente.telefono, pobjCliente.correo_electronico);

                if (intVal == 1)
                {
                    objRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                gobjContextoRT.Configuration.ProxyCreationEnabled = proxyCreationEnable;
            }
            return objRespuesta;
        }

        public bool modClientes(cliente pobjCliente)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoRT.PA_modCliente(pobjCliente.id, pobjCliente.nombre, pobjCliente.apellidos, pobjCliente.telefono, pobjCliente.correo_electronico);
                if (intVal == 1)
                {
                    objRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                gobjContextoRT.Configuration.ProxyCreationEnabled = proxyCreationEnable;
            }
            return objRespuesta;
        }

        public bool delClientes(cliente pobjCliente)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;

            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoRT.PA_delCliente(pobjCliente.id);
                if (intVal == 1)
                {
                    objRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                gobjContextoRT.Configuration.ProxyCreationEnabled = proxyCreationEnable;
            }
            return objRespuesta;
        }
    }
}
