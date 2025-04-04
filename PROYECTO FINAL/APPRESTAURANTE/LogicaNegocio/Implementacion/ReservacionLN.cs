using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio.Interfaces;

namespace LogicaNegocio.Implementacion
{
    public class ReservacionLN : IReservacionLN
    {
        public static RTEntities _gobjContextoRT= new RTEntities();
        private readonly IReservacionAD _objReservacionAD = new ReservacionAD(_gobjContextoRT);

        public List<PA_recReservacion_Result> recReservacionesln()
        {
            List<PA_recReservacion_Result> lobjRespuesta = new List<PA_recReservacion_Result>();
            try
            {
                lobjRespuesta = _objReservacionAD.recReservaciones();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public PA_recReservacionXId_Result recReservacionesXIdln(int pId)
        {
            PA_recReservacionXId_Result objRespuesta = new PA_recReservacionXId_Result();
            try
            {
                objRespuesta = _objReservacionAD.recReservacionesxid(pId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }

        public bool insReservacionln(reservacione pobjReservacion)
        {
            bool objRespuesta = new bool();
            //var proxyCreationEnable = _gobjContextoNW.Configuration.ProxyCreationEnabled;
            try
            {
                objRespuesta = _objReservacionAD.insReservaciones(pobjReservacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //finally
            //{
            //    _gobjContextoNW.Configuration.ProxyCreationEnabled = proxyCreationEnable;
            //}
            return objRespuesta;
        }

        public bool modReservacionln(reservacione pobjReservacion)
        {
            bool objRespuesta = new bool();

            try
            {
                objRespuesta = _objReservacionAD.modReservaciones(pobjReservacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRespuesta;
        }

        public bool delReservacionln(reservacione pobjReservacion)
        {
            bool objRespuesta = new bool();

            try
            {
                objRespuesta = _objReservacionAD.delReservaciones(pobjReservacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRespuesta;
        }
    }
}
