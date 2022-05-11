using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AbsoluteClicked(object sender,EventArgs e)
        {
            //Abre uma nova view
            Navigation.PushAsync(new View.AbsoluteLayoutView());

        }

        private void GridLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.GridLayoutView());
        }

        private void StackLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.StackLayoutView());
        }

        private void FlexLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.FlexLayoutView());
        }

        private void RelativeLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.RelativeLayoutView());
        }
    }
}
