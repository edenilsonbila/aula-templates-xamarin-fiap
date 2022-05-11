using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DinamicoView : ContentPage
    {
        bool temaPadrao;
        public DinamicoView()
        {
            InitializeComponent();

            temaPadrao = true;
            Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (temaPadrao)
            {
                Resources["TextoEstiloDinamico"] = Resources["TextoVermelho"];
                temaPadrao = false;
            }
            else
            {
                Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];
                temaPadrao = true;
            }
        }
    }
}