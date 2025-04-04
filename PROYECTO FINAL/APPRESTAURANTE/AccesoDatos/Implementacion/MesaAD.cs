using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class MesaAD : IMesaAD
    {
        private RTEntities gobjContextoRT;

        public MesaAD(RTEntities _gobjContexto)
        {
            this.gobjContextoRT = _gobjContexto;
        }

        public List<PA_recMesa_Result> recMesas()
        {
            List<PA_recMesa_Result> lobjRespuesta = new List<PA_recMesa_Result>();

            try
            {
                lobjRespuesta = gobjContextoRT.PA_recMesa().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
        //llamar por id

        public PA_recMesaXId_Result recMesasxid(int pId)
        {
            PA_recMesaXId_Result objRespuesta = new PA_recMesaXId_Result();

            try
            {
                objRespuesta = gobjContextoRT.PA_recMesaXId(pId).Single();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }
        public bool insMesas(mesa pobjMesa)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;

                intVal = gobjContextoRT.PA_insMesa(pobjMesa.numero_mesa, pobjMesa.descripcion);

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

        public bool modMesas(mesa pobjMesa)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoRT.PA_modMesa(pobjMesa.id,pobjMesa.numero_mesa,pobjMesa.descripcion);
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

        public bool delMesas(mesa pobjMesa)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoRT.PA_delMesa(pobjMesa.id);
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
