using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsObtenerMision
    {

        /// <summary>
        /// Este método devuelve una mision que tenga la misma id que se obtiene como parámetro
        /// Postcondición: Nada
        /// Precondición: Devolverá una mision
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsMisiones ObtenerMisionPorId(int id)
        {
            ObservableCollection<clsMisiones> obtenerMisiones = clsListaMisiones.listaMisionesCompleta();
            clsMisiones mision = new clsMisiones();

            foreach(clsMisiones misiones in obtenerMisiones)
            {

               if(misiones.idMision == id)
                {
                    mision = misiones;
                }

            }


            return mision;

        }

    }
}
