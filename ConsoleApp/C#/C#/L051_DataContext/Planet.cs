using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L051_DataContext
{
    internal class Planet
    {
        private string name;

        public string Name
        {
            get => name; 
            set
            {
                name = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }

        }

        public double Mass { get; set; }


        public ObservableCollection<Moon> Moons { get; set; } = new ObservableCollection<Moon>();

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
