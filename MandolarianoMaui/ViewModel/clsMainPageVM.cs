using BL;
using Entidades;
using MandolarianoMaui.ViewModel.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MandolarianoMaui.ViewModel
{
    public class clsMainPageVM : clsVMBase
    {

        #region Atributos

        private ObservableCollection<clsMisiones> listadoMisionesCompleto;
        private clsMisiones misionSeleccionada;
        private DelegateCommand mostrarDetallesCommand;
        private bool datosMisionEsVisible;

        #endregion


        #region Propiedades

        public ObservableCollection<clsMisiones> ListadoMisionesCompleto
        {
            get { return DAL.clsListaMisiones.listaMisionesCompleta(); }

        }


        public clsMisiones MisionSeleccionada
        {
            get { return misionSeleccionada; }

            set { misionSeleccionada = value;
                mostrarDetallesCommand.RaiseCanExecuteChanged();
                NotifyPropertyChanged();
            }
        }

        public DelegateCommand MostrarDetallesCommand
        {
            get {
              
                return mostrarDetallesCommand; }

            

        }

        public bool DatosMisionEsVisible
        {
            get
            {
                return datosMisionEsVisible;
                
            }

            set { datosMisionEsVisible = value;
                NotifyPropertyChanged();
            }
        }



        #endregion

        #region Constructores

        public clsMainPageVM()
        {
            mostrarDetallesCommand = new DelegateCommand(mostrarDetallesCommand_Execute, mostrarDetallesCommand_CanExecute);
        }
        #endregion


        #region Comandos
        /// <summary>
        /// Método que devolverá un booleano que indicará si puede o no ejecutarse
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool mostrarDetallesCommand_CanExecute()
        {
            bool canExecute = false;

            if (misionSeleccionada != null)
            {
                canExecute = true;
            }


            return canExecute;
        }

        /// <summary>
        /// Mostrará los detalles de la misión seleccionada mediante el booleano datosMisionEsVisible
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void mostrarDetallesCommand_Execute()
        {
                     
            DatosMisionEsVisible = true;   

        }
        #endregion
    }
}

