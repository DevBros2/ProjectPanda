using ProjectPanda.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.AppointmentViewModels
{
    public class CalenderViewModel : BaseViewModel
    {
        private DateTime? _date;
        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        private ObservableCollection<XamForms.Controls.SpecialDate> openBoookings;
        public ObservableCollection<XamForms.Controls.SpecialDate> OpenBoookings
        {
            get { return openBoookings; }
            set { openBoookings = value; OnPropertyChanged(nameof(OpenBoookings)); }
        }

        public ICommand DateChosen
        {
            get
            {
                return new Command((obj) => {
                    System.Diagnostics.Debug.WriteLine(obj as DateTime?);
                });
            }
        }
    }
}
