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
    public class ReservacionController : Controller
    {
        private IReservacionLN objReservaciones = new ReservacionLN();

        //vistas
        public ActionResult ListReservaciones()
        {
            List<PA_recReservacion_Result> lstReservaciones = new List<PA_recReservacion_Result>();

            List<M_Reservacion> lstModeloReservacion = new List<M_Reservacion>();

            lstReservaciones = objReservaciones.recReservacionesln();

            foreach (var reservacion in lstReservaciones)
            {
                M_Reservacion objModeloReservacion = new M_Reservacion();

                objModeloReservacion.numero_reservacion =  reservacion.numero_reservacion;
                objModeloReservacion.id_cliente = reservacion.id_cliente;
                objModeloReservacion.numero_mesa = reservacion.numero_mesa;
                objModeloReservacion.id_menu = reservacion.id_menu;
                objModeloReservacion.cantidad = reservacion.cantidad;
                objModeloReservacion.fecha_reservacion = reservacion.fecha_reservacion;


                lstModeloReservacion.Add(objModeloReservacion);
            }

            return View(lstModeloReservacion);

        }
        public ActionResult AgregarReservaciones()
        {
            return View();
        }
        public ActionResult ModificaReservaciones(int id)
        {
            PA_recReservacionXId_Result objReservacion = new PA_recReservacionXId_Result();
            objReservacion = objReservaciones.recReservacionesXIdln(id);
            M_Reservacion objReservacionEnt = new M_Reservacion()
            {
                id_cliente = objReservacion.id_cliente,
                id_menu = objReservacion.id_menu,
                numero_reservacion = objReservacion.numero_reservacion,
                fecha_reservacion = objReservacion.fecha_reservacion,
                numero_mesa = objReservacion.numero_mesa,
                cantidad = objReservacion.cantidad
            };
            return View(objReservacionEnt);
        }

        public ActionResult EliminaReservaciones(int id)
        {
            PA_recReservacionXId_Result objReservacion = new PA_recReservacionXId_Result();
            objReservacion = objReservaciones.recReservacionesXIdln(id);
            M_Reservacion objReservacionEnt = new M_Reservacion()
            {
                id_cliente = objReservacion.id_cliente,
                id_menu = objReservacion.id_menu,
                numero_reservacion=objReservacion.numero_reservacion,
                fecha_reservacion = objReservacion.fecha_reservacion,
                numero_mesa = objReservacion.numero_mesa,
                cantidad = objReservacion.cantidad

            };
            return View(objReservacionEnt);
        }

        public ActionResult DetalleReservaciones(int id)
        {
            PA_recReservacionXId_Result objReservacion = new PA_recReservacionXId_Result();
            reservacione objReservacionEnt = new reservacione();
            objReservacionEnt.numero_reservacion = objReservacion.numero_reservacion;
            objReservacionEnt.fecha_reservacion = objReservacion.fecha_reservacion;
            objReservacionEnt.cliente.nombre = objReservacion.nombre;
            objReservacionEnt.cliente.apellidos = objReservacion.apellidos;
            objReservacionEnt.numero_mesa = objReservacion.numero_mesa;
            objReservacionEnt.menu.descripcion = objReservacion.descripcion;
            objReservacionEnt.menu.precio = objReservacion.precio;
            objReservacionEnt.cantidad = objReservacion.cantidad;
            return View(objReservacionEnt);
        }

        //Metodos

        public ActionResult IngresarReservacion(reservacione objReservacion)
        {
            List<PA_recReservacion_Result> lstReservaciones = new List<PA_recReservacion_Result>();
            List<M_Reservacion> lstModeloReservacion = new List<M_Reservacion>();
            try
            {
                if (objReservaciones.insReservacionln(objReservacion))
                {
                    lstReservaciones = objReservaciones.recReservacionesln();

                    foreach (var reservacion in lstReservaciones)
                    {
                        M_Reservacion objModeloReservacion= new M_Reservacion();

                        objModeloReservacion.numero_reservacion = reservacion.numero_reservacion;
                        objModeloReservacion.id_cliente = reservacion.id_cliente;
                        objModeloReservacion.numero_mesa = reservacion.numero_mesa;
                        objModeloReservacion.id_menu = reservacion.id_menu;
                        objModeloReservacion.cantidad = reservacion.cantidad;
                        objModeloReservacion.fecha_reservacion = reservacion.fecha_reservacion;
                       
                        lstModeloReservacion.Add(objModeloReservacion);
                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListReservaciones", lstModeloReservacion);
        }

        public ActionResult ModificarReservacion(reservacione objReservacion)
        {
            List<PA_recReservacion_Result> lstReservaciones = new List<PA_recReservacion_Result>();
            List<M_Reservacion> lstModeloReservacion = new List<M_Reservacion>();
            try
            {
                if (objReservaciones.modReservacionln(objReservacion))
                {
                    lstReservaciones = objReservaciones.recReservacionesln();

                    foreach (var reservacion in lstReservaciones)
                    {
                        M_Reservacion objModeloReservacion = new M_Reservacion();

                        objModeloReservacion.numero_reservacion = reservacion.numero_reservacion;
                        objModeloReservacion.id_cliente = reservacion.id_cliente;
                        objModeloReservacion.numero_mesa = reservacion.numero_mesa;
                        objModeloReservacion.id_menu = reservacion.id_menu;
                        objModeloReservacion.cantidad = reservacion.cantidad;
                        objModeloReservacion.fecha_reservacion = reservacion.fecha_reservacion;

                        lstModeloReservacion.Add(objModeloReservacion);
                    }

                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListReservaciones",lstModeloReservacion);
        }

        public ActionResult EliminarReservacion(reservacione objReservacion)
        {
            List<PA_recReservacion_Result> lstReservaciones = new List<PA_recReservacion_Result>();
            List<M_Reservacion> lstModeloReservacion = new List<M_Reservacion>();
            try
            {
                if (objReservaciones.delReservacionln(objReservacion))
                {
                    lstReservaciones = objReservaciones.recReservacionesln();

                    foreach (var reservacion in lstReservaciones)
                    {
                        M_Reservacion objModeloReservacion = new M_Reservacion();

                        objModeloReservacion.numero_reservacion = reservacion.numero_reservacion;
                        objModeloReservacion.id_cliente = reservacion.id_cliente;
                        objModeloReservacion.numero_mesa = reservacion.numero_mesa;
                        objModeloReservacion.id_menu = reservacion.id_menu;
                        objModeloReservacion.cantidad = reservacion.cantidad;
                        objModeloReservacion.fecha_reservacion = reservacion.fecha_reservacion;

                        lstModeloReservacion.Add(objModeloReservacion);
                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListReservaciones", lstModeloReservacion);
        }

        [HttpPost]
        public ActionResult Acciones(string submitButton, reservacione pReservacion)
        {
            try
            {
                reservacione objRe = new reservacione();

                objRe.numero_reservacion = pReservacion.numero_reservacion;
                objRe.id_cliente = pReservacion.id_cliente;
                objRe.numero_mesa = pReservacion .numero_mesa;
                objRe.id_menu = pReservacion .id_menu;
                objRe.cantidad = pReservacion.cantidad;
                objRe.fecha_reservacion = pReservacion.fecha_reservacion;


                switch (submitButton)
                {
                    case "Agregar":
                        return IngresarReservacion(objRe);

                    case "Actualizar":
                        return ModificarReservacion(objRe);

                    case "Eliminar":
                        return EliminarReservacion(objRe);

                    default:

                        return RedirectToAction("ListReservaciones", "Reservacion");
                }

            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Reservacion", "Acciones"));
            }
        }
    }
}