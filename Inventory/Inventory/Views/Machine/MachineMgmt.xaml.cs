using Inventory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inventory.Views.Machine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MachineMgmt : ContentView
    {
        public MachineMgmt()
        {
            InitializeComponent();
            BindingContext = new MachineMgmtViewModel();
        }
    }
}