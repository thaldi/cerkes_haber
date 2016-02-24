using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerkes_haber.model
{
    public class Users : INotifyPropertyChanged
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public uint Age { get; set; }
        public Uri UserImage { get; set; }
        public string Village { get; set; }
        public string City { get; set; }
        public string Part { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
