using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
using ProjectPanda.Views;
using System.Collections.ObjectModel;

using Xamarin.Forms;


namespace ProjectPanda.ViewModels
{
    public class DoctorListViewModel
    {
        public ObservableCollection<DocAvaliable> Doctors { get; set; }
        //public Command LoadDoctorsCommand { get; set; }

        public DoctorListViewModel()
        {
           // Name = "Doctors";
            Doctors = new ObservableCollection<DocAvaliable>();

            // Method below needs work, but can be found in ItemPage.xaml.cs
            //async Task ShowDoctorCommand()
            //{
            //    MessagingCenter.Send(this, "ThisDoctor", item);
            //    await Navigation.PushAsync(new AppoinmentView());
            //}

        }
    }

    
        
}
