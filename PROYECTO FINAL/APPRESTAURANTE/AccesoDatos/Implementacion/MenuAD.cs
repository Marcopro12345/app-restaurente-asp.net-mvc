using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class MenuAD: IMenuAD
    {
        private RTEntities gobjContextoRT;

        public MenuAD(RTEntities _gobjContexto)
        {
            this.gobjContextoRT = _gobjContexto;
        }

        public List<PA_recMenu_Result> recMenus()
        {
            List<PA_recMenu_Result> lobjRespuesta = new List<PA_recMenu_Result>();

            try
            {
                lobjRespuesta = gobjContextoRT.PA_recMenu().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
        //llamar por id

        public PA_recMenuXId_Result recMenusxid(int pId)
        {
            PA_recMenuXId_Result objRespuesta = new PA_recMenuXId_Result();

            try
            {
                objRespuesta = gobjContextoRT.PA_recMenuXId(pId).Single();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }
        public bool insMenus(menu pobjMenu)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;

                intVal = gobjContextoRT.PA_insMenu(pobjMenu.descripcion, pobjMenu.precio);

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

        public bool modMenus(menu pobjMenu)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoRT.PA_modMenu(pobjMenu.id, pobjMenu.descripcion,pobjMenu.precio);
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

        public bool delMenus(menu pobjMenu)
        {
            var proxyCreationEnable = gobjContextoRT.Configuration.ProxyCreationEnabled;
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoRT.PA_delMenu(pobjMenu.id);
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
