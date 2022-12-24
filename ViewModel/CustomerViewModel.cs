using Android.Locations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace maui_navigation.ViewModel
{
    public class CustomerViewModel : INotifyPropertyChanged
    
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private string address;
        private string city;

        protected void onPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public string Name { get => name; set { name = value;

                onPropertyChanged();
            } }

        public string Address { get => address; set { address = value; onPropertyChanged(); } }

        public string City { get => city; set { city = value; onPropertyChanged(); } }

    }
}
