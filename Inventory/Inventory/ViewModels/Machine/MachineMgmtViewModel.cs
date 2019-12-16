using Inventory.Data;
using Inventory.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Inventory.ViewModels
{
    public class MachineMgmtViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Machine> machineList;
        private SQLiteConnection SQLiteConnection;
        public Machine Machine { get; set; }
        public MachineMgmtViewModel()
        {
            this.machineList = new ObservableCollection<Machine>();
            this.machineList = GetAllMachine();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<Machine> GetAllMachine() {
            SQLiteConnection = DependencyService.Get<ISQLite>().GetDBConnection();
            var data = (from machine in
                        SQLiteConnection.Table<Machine>()
                        select machine);
            return new ObservableCollection<Machine>(data);
        }
        public void AddNewMachine(Machine machine) {
            SQLiteConnection.Insert(this.Machine);
            this.Machine = new Machine { Name = "", Number = 0 };
        }
        public ObservableCollection<Machine> MachineList
        {
            get
            {
                return machineList;
            }
            set
            {
                machineList = value;
                OnPropertyChanged();
            }
        }
        public Command AddMachine
        {
            get {
                return new Command(() => {
                    AddNewMachine(this.Machine);
                    this.machineList = GetAllMachine();
                });            
            }
        }
   
    }
}
