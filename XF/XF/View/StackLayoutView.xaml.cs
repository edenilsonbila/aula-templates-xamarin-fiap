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
    public partial class StackLayoutView : ContentPage
    {
        public StackLayoutView()
        {
            InitializeComponent();
        }
    }
}