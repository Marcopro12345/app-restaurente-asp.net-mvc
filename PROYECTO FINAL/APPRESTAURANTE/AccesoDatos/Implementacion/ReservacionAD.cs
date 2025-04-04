using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class ReservacionAD : IReservacionAD
    {
        private RTEntities gobjContextoRT;

        public ReservacionAD(RTEntities _gobjContexto)
        {
            this.gobjContextoRT = _gobjContexto;
        }

        public List<PA_recReservacion_Result> recReservaciones()
        {
            List<PA_recReservacion_Result> lobjRespuesta = new List<PA_recReservacion_Result>();

            try
            {
                lobjRespuesta = gobjContextoRT.PA_recReservacion().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
        //llamar por id

        public PA_recReservacionXId_Result recReservacionesxid(int pId)
        {
            PA_recReservacionXId_Result objRespuesta = new PA_recReservacionXId_Result();

            try
            {
                objRespuesta = gobjContextoRT.PA_recReservacionXId(pId).Single();

            }
            catch (Exception ex) 
            {
                throw ex;
            }
            return objRespuesta;
        }
        public bool insReservaciones(reservacione pobjReservacion)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;

                intVal = gobjContextoRT.PA_insReservacion(pobjReservacion.id_cliente, pobjReservacion.numero_mesa, pobjReservacion.id_menu, pobjReservacion.cantidad, pobjReservacion.fecha_reservacion);

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

        public bool modReservaciones(reservacione pobjReservacion)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoRT.PA_modReservacion(pobjReservacion.numero_reservacion, pobjReservacion.id_cliente, pobjReservacion.numero_mesa, pobjReservacion.id_menu, pobjReservacion.cantidad, pobjReservacion.fecha_reservacion);
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

        public bool delReservaciones(reservacione pobjReservacion)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoRT.PA_delReservacion(pobjReservacion.numero_reservacion);
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
