using Entidades;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;

namespace DAL
{
    public class clsListaMisiones
    {


        /// <summary>
        /// Se crea un método que retorna una lista completa con las misiones, teniendo toda la información necesaria. 
        /// 
        /// Precondición: Nada
        /// Postcondición: Retornará una lista completa de misiones
        /// </summary>
        /// <returns> List<clsMisiones></returns>
        public static ObservableCollection<clsMisiones> listaMisionesCompleta()
        {


            ObservableCollection<clsMisiones> listaMisiones = new ObservableCollection<clsMisiones>();

            listaMisiones.Add(new clsMisiones
            {
                idMision = 1,
                NombreMision = "Rescate de Baby Yoda",
                Descripcion = "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.",
                Recompensa = 5000
            });

            listaMisiones.Add(new clsMisiones
            {
                idMision = 2,
                NombreMision = "Recuperar armadura Beskar",
                Descripcion = "La armadura de Bershka ha sido robada. Debes encontrarla. El Beskar fue utilizado en gran medida por " +
                "los mandalorianos como parte de su iniciativa colectiva para el avance tecnológico. Se vieron obligados durante muchos años " +
                "a enfrentarse a los Jedi en luchas de poder, pero no pudieron explicar cómo los Jedi usaron la Fuerza para frustrarlos. " +
                "El Beskar ayudó a la causa, e incluso a defenderse de un golpe indirecto de un sable de luz.",
                Recompensa = 2000
            });

            listaMisiones.Add(new clsMisiones
            {
                idMision = 3,
                NombreMision = "Planeta Sorgon",
                Descripcion = "Debes llevar a un niño de vuelta a su planeta natal Sorgon.",
                Recompensa = 500
            });


            listaMisiones.Add(new clsMisiones
            {
                idMision = 4,
                NombreMision = "Renacuajos",
                Descripcion = "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.",
                Recompensa = 500
            });



            return listaMisiones;
        }



    }
}