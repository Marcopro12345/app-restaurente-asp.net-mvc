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
    public class MenuLN : IMenuLN
    {
        public static RTEntities _gobjContextoRT = new RTEntities();
        private readonly IMenuAD _objMenuAD = new MenuAD(_gobjContextoRT);

        public List<PA_recMenu_Result> recMenusln()
        {
            List<PA_recMenu_Result> lobjRespuesta = new List<PA_recMenu_Result>();
            try
            {
                lobjRespuesta = _objMenuAD.recMenus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public PA_recMenuXId_Result recMenusXIdln(int pId)
        {
            PA_recMenuXId_Result objRespuesta = new PA_recMenuXId_Result();
            try
            {
                objRespuesta = _objMenuAD.recMenusxid(pId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }

        public bool insMenuln(menu pobjMenu)
        {
            bool objRespuesta = new bool();
           
            try
            {
                objRespuesta = _objMenuAD.insMenus(pobjMenu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
            return objRespuesta;
        }

        public bool modMenuln(menu pobjMenu)
        {
            bool objRespuesta = new bool();

            try
            {
                objRespuesta = _objMenuAD.modMenus(pobjMenu);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRespuesta;
        }

        public bool delMenuln(menu pobjMenu)
        {
            bool objRespuesta = new bool();

            try
            {
                objRespuesta = _objMenuAD.delMenus(pobjMenu);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRespuesta;
        }
    }
}
