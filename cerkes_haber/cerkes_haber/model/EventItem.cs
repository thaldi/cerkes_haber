using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cerkes_haber.model
{
    public class EventItem : INotifyPropertyChanged
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Place { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public Uri ImageUrl { get; set; }
        public Color Color { get; set; }
        public string Flag { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
