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
    public class MenuController : Controller
    {
        private IMenuLN objMenus = new MenuLN();

        //vstas
        public ActionResult ListMenus()
        {
            List<PA_recMenu_Result> lstMenus = new List<PA_recMenu_Result>();

            List<M_Menu> lstModeloMenu = new List<M_Menu>();

             lstMenus = objMenus.recMenusln();

            foreach (var menu in lstMenus)
            {
                M_Menu objModeloMenu = new M_Menu();

                objModeloMenu.id = menu.id;
                objModeloMenu.descripcion = menu.descripcion;
                objModeloMenu.precio = menu.precio;

                lstModeloMenu.Add(objModeloMenu);
            }
            return View(lstModeloMenu);


        }
        public ActionResult AgregarMenus()
        {
            return View();
        }
        public ActionResult ModificaMenus(int id)
        {
            PA_recMenuXId_Result objMenu = new PA_recMenuXId_Result();
            M_Menu objMenuEnt = new M_Menu();
            objMenu = objMenus.recMenusXIdln(id);
            objMenuEnt.id = objMenu.id;
            objMenuEnt.descripcion = objMenu.descripcion;
            objMenuEnt.precio = objMenu.precio;
            return View(objMenuEnt);
        }

        public ActionResult EliminaMenus(int id)
        {
            PA_recMenuXId_Result objMenu = new PA_recMenuXId_Result();


            M_Menu objMenuEnt = new M_Menu();
            objMenu = objMenus.recMenusXIdln(id);
            objMenuEnt.id = objMenu.id;
            objMenuEnt.descripcion = objMenu.descripcion;
            objMenuEnt.precio = objMenu.precio;


            return View(objMenuEnt);
        }

        public ActionResult DetalleClientes(int id)
        {
            PA_recMenuXId_Result objMenu = new PA_recMenuXId_Result();
            menu objMenuEnt = new menu();
            objMenuEnt.id = objMenu.id;
            objMenuEnt.descripcion = objMenu.descripcion;
            objMenuEnt.precio = objMenu.precio;
        
            return View(objMenuEnt);
        }

        //Metodos

        public ActionResult IngresarMenu(menu objMenu)
        {
            List<PA_recMenu_Result> lstMenus = new List<PA_recMenu_Result>();
            List<M_Menu> lstModeloMenu = new List<M_Menu>();
            try
            {
                if (objMenus.insMenuln(objMenu))
                {
                    lstMenus = objMenus.recMenusln();

                    foreach (var menu in lstMenus)
                    {
                        M_Menu objModeloMenu = new M_Menu();

                        objModeloMenu.id = menu.id;
                        objModeloMenu.descripcion = menu.descripcion;
                        objModeloMenu.precio = menu.precio;
                        lstModeloMenu.Add(objModeloMenu);
                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListMenus", lstModeloMenu);
        }

        public ActionResult ModificarMenu(menu objMenu)
        {
            List<PA_recMenu_Result> lstMenus = new List<PA_recMenu_Result>();
            List<M_Menu> lstModeloMenu = new List<M_Menu>();
            try
            {
                if (objMenus.modMenuln(objMenu))
                {
                    lstMenus = objMenus.recMenusln();
                    foreach (var menu in lstMenus)
                    {
                        M_Menu objModeloMenu = new M_Menu();

                        objModeloMenu.id = menu.id;
                        objModeloMenu.descripcion = menu.descripcion;
                        objModeloMenu.precio = menu.precio;

                        lstModeloMenu.Add(objModeloMenu);
                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListMenus", lstModeloMenu);
        }

        public ActionResult EliminarMenu(menu objMenu)
        {
            List<PA_recMenu_Result> lstMenus= new List<PA_recMenu_Result>();
            List<M_Menu> lstModeloMenu = new List<M_Menu>();
            try
            {
                if (objMenus.delMenuln(objMenu))
                {
                    lstMenus = objMenus.recMenusln();
                    foreach (var menu in lstMenus)
                    {
                        M_Menu objModeloMenu = new M_Menu();

                        objModeloMenu.id = menu.id;
                        objModeloMenu.descripcion = menu.descripcion;
                        objModeloMenu.precio = menu.precio;

                        lstModeloMenu.Add(objModeloMenu);
                    }

                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "RegistroDecomiso", "AccionDecomiso"));
            }
            return View("ListMenus", lstModeloMenu);
        }

        [HttpPost]
        public ActionResult Acciones(string submitButton, menu pMenu)
        {
            try
            {
                menu objM = new menu();

                objM.id = pMenu.id;
                objM.descripcion= pMenu.descripcion;
                objM.precio= pMenu.precio;
                

                switch (submitButton)
                {
                    case "Agregar":
                        return IngresarMenu(objM);

                    case "Actualizar":
                        return ModificarMenu(objM);

                    case "Eliminar":
                        return EliminarMenu(objM);

                    default:

                        return RedirectToAction("ListMenus", "menu");
                }

            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "menu", "Acciones"));
            }
        }
    }
}