using APPRESTAURANTE.Models;
using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPRESTAURANTE.Controllers
{
    public class ClienteController : Controller
    {
        private IClienteLN objClientes = new ClienteLN();

        //vistas
        public ActionResult ListClientes()
        {
            List<PA_recCliente_Result> IstClientes = new List<PA_recCliente_Result>();

            List<M_Cliente> lstModeloCliente = new List<M_Cliente>();

            IstClientes = objClientes.recClientesln();


            foreach (var cliente in IstClientes)
            {
                M_Cliente objModeloCliente = new M_Cliente();

                objModeloCliente.id = cliente.id;
                objModeloCliente.nombre = cliente.nombre;
                objModeloCliente.apellidos = cliente.apellidos;
                objModeloCliente.telefono = cliente.telefono;
                objModeloCliente.correo_electronico = cliente.correo_electronico;

                lstModeloCliente.Add(objModeloCliente);

            }

            return View(lstModeloCliente);

        }
        public ActionResult AgregarClientes()
        {
            return View();
        }
        public ActionResult ModificaClientes(int id)
        {
            PA_recClienteXId_Result objCliente = new PA_recClienteXId_Result();
            M_Cliente objClienteEnt = new M_Cliente();
            objCliente = objClientes.recClientesXIdln(id);
            objClienteEnt.id = objCliente.id;
            objClienteEnt.nombre = objCliente.nombre;
            objClienteEnt.apellidos = objCliente.apellidos;
            objClienteEnt.telefono = objCliente.telefono;
            objClienteEnt.correo_electronico = objCliente.correo_electronico;
            return View(objClienteEnt);
        }

        public ActionResult EliminaClientes(int id)
        {
            PA_recClienteXId_Result objCliente = new PA_recClienteXId_Result();
            

            M_Cliente objClienteEnt = new M_Cliente();
            objCliente = objClientes.recClientesXIdln(id);
            objClienteEnt.id = objCliente.id;
            objClienteEnt.nombre = objCliente.nombre;
            objClienteEnt.apellidos = objCliente.apellidos;
            objClienteEnt.telefono = objCliente.telefono;
            objClienteEnt.correo_electronico = objCliente.correo_electronico;

            return View(objClienteEnt);
        }

        public ActionResult DetalleClientes(int id)
        {
            PA_recClienteXId_Result objCliente = new PA_recClienteXId_Result();
            cliente objClienteEnt = new cliente();
            objClienteEnt.id = objCliente.id;
            objClienteEnt.nombre = objCliente.nombre;
            objClienteEnt.apellidos = objCliente.apellidos;
            objClienteEnt.telefono = objCliente.telefono;
            objClienteEnt.correo_electronico = objCliente.correo_electronico;
            return View(objClienteEnt);
        }

        //Metodos

        public ActionResult IngresarCliente(cliente objCliente)
        {
            List<PA_recCliente_Result> IstClientes = new List<PA_recCliente_Result>();
            List<M_Cliente> lstModeloCliente = new List<M_Cliente>();
            try
            {
                if (objClientes.insClienteln(objCliente))
                {
                    IstClientes = objClientes.recClientesln();
                    foreach (var cliente in IstClientes)
                    {
                        M_Cliente objModeloCliente = new M_Cliente();

                        objModeloCliente.id = cliente.id;
                        objModeloCliente.nombre = cliente.nombre;
                        objModeloCliente.apellidos = cliente.apellidos;
                        objModeloCliente.telefono = cliente.telefono;
                        objModeloCliente.correo_electronico = cliente.correo_electronico;

                        lstModeloCliente.Add(objModeloCliente);

                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListClientes", lstModeloCliente);
        }

        public ActionResult ModificarCliente(cliente objCliente)
        {
            List<PA_recCliente_Result> IstClientes = new List<PA_recCliente_Result>();
            List<M_Cliente> lstModeloCliente = new List<M_Cliente>();
            try
            {
                if (objClientes.modClienteln(objCliente))
                {
                    IstClientes = objClientes.recClientesln();
                    foreach (var cliente in IstClientes)
                    {
                        M_Cliente objModeloCliente = new M_Cliente();

                        objModeloCliente.id = cliente.id;
                        objModeloCliente.nombre = cliente.nombre;
                        objModeloCliente.apellidos = cliente.apellidos;
                        objModeloCliente.telefono = cliente.telefono;
                        objModeloCliente.correo_electronico = cliente.correo_electronico;

                        lstModeloCliente.Add(objModeloCliente);

                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListClientes", lstModeloCliente);
        }

        public ActionResult EliminarCliente(cliente objCliente)
        {
            List<PA_recCliente_Result> IstClientes = new List<PA_recCliente_Result>();
            List<M_Cliente> lstModeloCliente = new List<M_Cliente>();
            try
            {
                if (objClientes.delClienteln(objCliente))
                {
                    IstClientes = objClientes.recClientesln();
                    foreach (var cliente in IstClientes)
                    {
                        M_Cliente objModeloCliente = new M_Cliente();

                        objModeloCliente.id = cliente.id;
                        objModeloCliente.nombre = cliente.nombre;
                        objModeloCliente.apellidos = cliente.apellidos;
                        objModeloCliente.telefono = cliente.telefono;
                        objModeloCliente.correo_electronico = cliente.correo_electronico;

                        lstModeloCliente.Add(objModeloCliente);

                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListClientes", lstModeloCliente);
        }

        [HttpPost]
        public ActionResult Acciones(string submitButton, M_Cliente pCliente)
        {
            try
            {
                cliente objClie = new cliente();

                objClie.id = pCliente.id;
                objClie.nombre = pCliente.nombre;
                objClie.apellidos = pCliente.apellidos;
                objClie.telefono = pCliente.telefono;
                objClie.correo_electronico = pCliente.correo_electronico;

                switch (submitButton)
                {
                    case "Agregar":
                        return IngresarCliente(objClie);

                    case "Actualizar":
                        return ModificarCliente(objClie);

                    case "Eliminar":
                        return EliminarCliente(objClie);

                    default:

                        return RedirectToAction("ListClientes", "cliente");
                }

            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "cliente", "Acciones"));
            }
        }
    }
}