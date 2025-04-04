using APPRESTAURANTE.Models;
using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPRESTAURANTE.Controllers
{
    public class MesaController : Controller
    {
        private IMesaLN objMesas = new MesaLN();

        //vistas
        public ActionResult ListMesas()
        {
            List<PA_recMesa_Result> lstMesas = new List<PA_recMesa_Result>();

            List<M_Mesa> lstModeloMesa = new List<M_Mesa>();

            lstMesas = objMesas.recMesasln();


            foreach (var mesa in lstMesas)
            {
                M_Mesa objModeloMesa= new M_Mesa();

                objModeloMesa.id = mesa.id;
                objModeloMesa.numero_mesa = mesa.numero_mesa;
                objModeloMesa.descripcion = mesa.descripcion;

                lstModeloMesa.Add(objModeloMesa);
            }

            return View(lstModeloMesa);

        }
        public ActionResult AgregarMesas()
        {
            return View();
        }
        public ActionResult ModificaMesas(int id)
        {
            PA_recMesaXId_Result objMesa = new PA_recMesaXId_Result();
            M_Mesa objMesaEnt = new M_Mesa();
            objMesa = objMesas.recMesasXIdln(id);
            objMesaEnt.id = objMesa.id;
            objMesaEnt.numero_mesa = objMesa.numero_mesa;
            objMesaEnt.descripcion = objMesa.descripcion;
            
            return View(objMesaEnt);
        }

        public ActionResult EliminaMesas(int id)
        {
            PA_recMesaXId_Result objMesa = new PA_recMesaXId_Result();


            M_Mesa objMesaEnt = new M_Mesa();
            objMesa = objMesas.recMesasXIdln(id);
            objMesaEnt.id = objMesa.id;
            objMesaEnt.numero_mesa = objMesa.numero_mesa;
            objMesaEnt.descripcion = objMesa.descripcion;


            return View(objMesaEnt);
        }

        public ActionResult DetalleMesas(int id)
        {
            PA_recMesaXId_Result objMesa = new PA_recMesaXId_Result();
            mesa objMesaEnt = new mesa();
            objMesaEnt.id = objMesa.id;
            objMesaEnt.numero_mesa = objMesa.numero_mesa;
            objMesaEnt.descripcion = objMesa.descripcion;
            return View(objMesaEnt);
        }

        //Metodos

        public ActionResult IngresarMesa(mesa objMesa)
        {
            List<PA_recMesa_Result> lstMesas = new List<PA_recMesa_Result>();
            List<M_Mesa> lstModeloMesa = new List<M_Mesa>();
            try
            {
                if (objMesas.insMesasln(objMesa))
                {
                    lstMesas = objMesas.recMesasln();
                    foreach (var mesa in lstMesas)
                    {
                        M_Mesa objModeloMesa = new M_Mesa();

                        objModeloMesa.id = mesa.id;
                        objModeloMesa.numero_mesa = mesa.numero_mesa;
                        objModeloMesa.descripcion = mesa.descripcion;

                        lstModeloMesa.Add(objModeloMesa);
                    }

                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListMesas", lstModeloMesa);
        }

        public ActionResult ModificarMesa(mesa objMesa)
        {
            List<PA_recMesa_Result> lstMesas = new List<PA_recMesa_Result>();
            List<M_Mesa> lstModeloMesa = new List<M_Mesa>();
            try
            {
                if (objMesas.modMesasln(objMesa))
                {
                    lstMesas = objMesas.recMesasln();
                    foreach (var mesa in lstMesas)
                    {
                        M_Mesa objModeloMesa = new M_Mesa();

                        objModeloMesa.id = mesa.id;
                        objModeloMesa.numero_mesa = mesa.numero_mesa;
                        objModeloMesa.descripcion = mesa.descripcion;

                        lstModeloMesa.Add(objModeloMesa);
                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListMesas", lstModeloMesa);
        }

        public ActionResult EliminarMesa(mesa objMesa)
        {
            List<PA_recMesa_Result> lstMesas = new List<PA_recMesa_Result>();
            List<M_Mesa> lstModeloMesa = new List<M_Mesa>();
            try
            {
                if (objMesas.delmesasln(objMesa))
                {
                    lstMesas = objMesas.recMesasln();
                    foreach (var mesa in lstMesas)
                    {
                        M_Mesa objModeloMesa = new M_Mesa();

                        objModeloMesa.id = mesa.id;
                        objModeloMesa.numero_mesa = mesa.numero_mesa;
                        objModeloMesa.descripcion = mesa.descripcion;

                        lstModeloMesa.Add(objModeloMesa);
                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListMesas", lstModeloMesa);
        }

        [HttpPost]
        public ActionResult Acciones(string submitButton, mesa pMesa)
        {
            try
            {

                mesa objMe = new mesa();

                objMe.id = pMesa.id;
                objMe.numero_mesa = pMesa.numero_mesa;
                objMe.descripcion = pMesa.descripcion;

                switch (submitButton)
                {
                    case "Agregar":
                        return IngresarMesa(objMe);

                    case "Actualizar":
                        return ModificarMesa(objMe);

                    case "Eliminar":
                        return EliminarMesa(objMe);

                    default:

                        return RedirectToAction("ListMesas", "mesa");
                }

            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "mesa", "Acciones"));
            }
        }
    }
}