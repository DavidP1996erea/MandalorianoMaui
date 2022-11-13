using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class clsObtenerMisionBL
    {

        /// <summary>
        /// Método que devuelve una misión por Id llamando al método de la DAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsMisiones obtenerMisionPorIdBL(int id)
        {


            return clsObtenerMision.ObtenerMisionPorId(id);

        }
    }
}
