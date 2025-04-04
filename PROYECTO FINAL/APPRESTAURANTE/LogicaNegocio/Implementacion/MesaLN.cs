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
    public class MesaLN : IMesaLN
    {

        public static RTEntities _gobjContextoRT = new RTEntities();
        private readonly IMesaAD _objMesaAD = new MesaAD(_gobjContextoRT);

        public List<PA_recMesa_Result> recMesasln()
        {
            List<PA_recMesa_Result> lobjRespuesta = new List<PA_recMesa_Result>();
            try
            {
                lobjRespuesta = _objMesaAD.recMesas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public PA_recMesaXId_Result recMesasXIdln(int pId)
        {
            PA_recMesaXId_Result objRespuesta = new PA_recMesaXId_Result();
            try
            {
                objRespuesta = _objMesaAD.recMesasxid(pId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }

        public bool insMesasln(mesa pobjMesa)
        {
            bool objRespuesta = new bool();
            //var proxyCreationEnable = _gobjContextoNW.Configuration.ProxyCreationEnabled;
            try
            {
                objRespuesta = _objMesaAD.insMesas(pobjMesa);
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

        public bool modMesasln(mesa pobjMesa)
        {
            bool objRespuesta = new bool();

            try
            {
                objRespuesta = _objMesaAD.modMesas(pobjMesa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRespuesta;
        }

        public bool delmesasln(mesa pobjMesa)
        {
            bool objRespuesta = new bool();

            try
            {
                objRespuesta = _objMesaAD.delMesas(pobjMesa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRespuesta;
        }
    }
}
