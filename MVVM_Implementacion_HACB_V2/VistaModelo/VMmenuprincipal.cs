using MVVM_Implementacion_HACB_V2.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Implementacion_HACB_V2.Vista;

namespace MVVM_Implementacion_HACB_V2.VistaModelo
{
    class VMmenuprincipal:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> listausuarios {  get; set; }
        #endregion
        #region CONTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
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
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina=parametros.Pagina;
            if(pagina.Contains("Entry, detepicker"))
            {
                await Navigation.PushAsync(new Page1());
            }
            if(pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if(pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        public void ProcesoSimple()
        {

        }
        public void MostraUsuarios()
        {
            listausuarios =new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina="Entry, detepicker, picker, label, navegacíon",
                    Icono="https://i.ibb.co/8s2V5XJ/9e3b75c071a6e7b297d3a6cdd88e322b.jpg"
                },
                new Mmenuprincipal
                {
                    Pagina="CollectionView sin enlace a base de datos",
                    Icono="https://i.ibb.co/M8nsgjR/3b435f9e94dd1e105296961a159bf8ab.jpg"
                },
                new Mmenuprincipal
                {
                    Pagina="Crud pokemon",
                    Icono="https://i.ibb.co/R6XRyS6/sticker-png-green-circle-gardevoir-drawing-gallade-fan-art-comics-cuteness-video-thumbnail.png"
                }
            };
        }
        #endregion
        #region COMANDOS
        //public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
