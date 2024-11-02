using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Implementacion_HACB_V2.Modelo;

namespace MVVM_Implementacion_HACB_V2.VistaModelo
{
    class VMpage2:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; } 
        #endregion
        #region CONTRUCTOR
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
            MostraUsuarios();
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set
            {
                SetValue(ref _Texto, value);
            }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        public void MostraUsuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre="Furina",
                    Imagen="https://i.ibb.co/GMxnP8D/dee6a9929c83caca52904d830909742c.jpg"
                },
                new Musuarios
                {
                    Nombre="Chara",
                    Imagen="https://i.ibb.co/8rfQ0xb/1cd7249df797f84bf5ca353739ce79a2.jpg"
                },
                new Musuarios
                {
                    Nombre="Miku",
                    Imagen="https://i.ibb.co/YkKYVK4/9cd071c09b495fe235e2c7494aaa5d08.jpg"
                }
            };
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
