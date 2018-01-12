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
        public IList<DocAvaliable> Doctors { get; set; }
        //public Command LoadDoctorsCommand { get; set; }
        public object SelectedItem { get; set; }

        public DoctorListViewModel()
        {
            // Name = "Doctors";
            Doctors = new List<DocAvaliable>();        
            GenerateDoctorList();
        }
             private void GenerateDoctorList()
            {
                  Doctors = new ObservableCollection<DocAvaliable>
                {
                    new DocAvaliable{ Name = "Dr Zulu ", Varsity="MBchB(Ukzn)"},
                    new DocAvaliable{ Name = "Dr Duma ", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)"},
                    new DocAvaliable{ Name = "Dr Moody ", Varsity="MBchB(Wits)"},
                    new DocAvaliable{ Name = "Dr McGhee ", Varsity="MBchB(Stellenbosch)"},
                    new DocAvaliable{ Name = "Dr Naidoo", Varsity="MBchB(Ukzn)"},
                    new DocAvaliable{ Name = "Dr Ngwenya ", Varsity="MBchB(Stellenbosch)"},
                };



            }



            // Method below needs work, but can be found in ItemPage.xaml.cs
            //async Task ShowDoctorCommand()
            //{
            //    MessagingCenter.Send(this, "ThisDoctor", item);
            //    await Navigation.PushAsync(new AppoinmentView());
            //}

        }
    

    
        
}
