using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjectPanda.Models
{
    public class DocAvaliable : INotifyPropertyChanged
    {
       
        private string Name;
        private string Varsity;

        public string name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string varsity
        {
            get { return varsity; }
            set
            {
                Varsity = value;
                OnPropertyChanged("Varsity");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        

        
        
    }
}
