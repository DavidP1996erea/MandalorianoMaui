using DAL;
using Mandaloriano.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Reflection;

namespace Mandaloriano.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult seleccionarMision(String lista)
        {

            //Se guarda en una variable la lista retornada por el método en la clase DAL, para que sea más facil su uso.
        var listaCompletaMisiones=clsListaMisiones.listaMisionesCompleta();



            
             //Se crea una lista tipo SelectListaItem, que será enviada a través del model a la vista para que cree la lista desplegable.
             
            List<SelectListItem> listaMisiones=new List<SelectListItem>();


            
            /*Para rellenar esta lista, se crea un bucle que recorrerá la otra lista con todas las misiones, y se añadirá
             * cada una al drop, teniendo como Value el id de la misión.
             */
            for (int i=0;i<listaCompletaMisiones.Count;i++)
            {

                listaMisiones.Add(new SelectListItem() { Text = listaCompletaMisiones[i].NombreMision.ToString(),
                                                            Value = listaCompletaMisiones[i].idMision.ToString() });

            }


            /*
             * Para saber que misión fue seleccionada, se hará uso del parámetro de entrada de este Controller, que coge el value
             * de la misión seleccionada, en este caso el id. Por lo que se crea un bucle que recorre la lista con todas las misiones 
             * para comprar los ids, cuando encuentra la misión correspondiente, se mete su información en 3 variables.
             */
            String Nombre = "";
            String Descripcion = "";
            String Recompensa = "";

            for (int i = 0; i < listaCompletaMisiones.Count; i++)
            {

                if (lista == clsListaMisiones.listaMisionesCompleta()[i].idMision.ToString())
                {


                    Nombre = "Nombre: " + listaCompletaMisiones[i].NombreMision.ToString();
                    Descripcion = "Descripción: " + listaCompletaMisiones[i].Descripcion.ToString();
                    Recompensa = "Recompensa: " + listaCompletaMisiones[i].Recompensa.ToString();

                }


            }


            // Estas variables se menten en 3 ViewBags para poder mostrarlos en la vista.
            ViewBag.mostrarNombre = Nombre;
            ViewBag.mostraDescripcion = Descripcion;
            ViewBag.mostrarRecompensa = Recompensa;
            return View(listaMisiones);

        }



      
    }
}