using Inventory.Data;
using Inventory.Models;
using Inventory.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inventory
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private SQLiteConnection SQLiteConnection;
        private Machine machine;
        public MainPage()
        {
            InitializeComponent();
            //SQLiteConnection = DependencyService.Get<ISQLite>().GetDBConnection();
           
            //SQLiteConnection.CreateTable<Machine>();
        }

        //private void SaveBtn_Clicked(object sender, EventArgs e)
        //{
        //    machine = new Machine();
        //    machine.Name = MachineName.Text;
        //    machine.Number = Convert.ToInt32(MachineNumber.Text);
        //    SQLiteConnection.Insert(machine);
        //    machine.Name = "";
        //    machine.Number =0;
        //}

        //private void ShowAllDataBtn_Clicked(object sender, EventArgs e)
        //{
        //    var data = (from machine in 
        //                SQLiteConnection.Table<Machine>() 
        //                select machine);
            
        //    DataList.ItemsSource = data;
        //}

        //private void EditMachine_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Message", "Edit Button Clicked", "OK");
        //}

        //private void Login(object sender, EventArgs e)
        //{
        //    DisplayAlert("Login","Login Successfully","Close");
        //    Navigation.PushAsync(new NextPage(Username.Text));
        //}
        //private void DateTime(object sender, EventArgs e)
        //{
        //    var dpick = dp.Date;
        //    var tpick = tp.Time;
        //    var pickedValue = MyPicker.SelectedItem.ToString();
        //    DateTimeLabel.Text = dpick.ToString() + tpick.ToString() + pickedValue;
        //}
    }
}
