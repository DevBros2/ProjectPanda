using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
using ProjectPanda.Views;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using ProjectPanda.ViewModels.Base;

namespace ProjectPanda.ViewModels
{
    public class DoctorListViewModel : BaseViewModel
    {
        private DocAvaliable _oldDoctorSelected;

        public ObservableCollection<DocAvaliable> Doctors { get; set; }
        //public Command LoadDoctorsCommand { get; set; }
        public object SelectedItem { get; set; }

        public DoctorListViewModel()
        {
            // Name = "Doctors";       
            GenerateDoctorList();
        }
             private void GenerateDoctorList()
            {
                  Doctors = new ObservableCollection<DocAvaliable>
                {
                    new DocAvaliable{ DocName = "Dr Zulu ", Varsity="MBchB(Ukzn)",ProfileImageURl="userplaceholder.png" , IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Duma ", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Moody ", Varsity="MBchB(Wits)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ DocName = "Dr McGhee ", Varsity="MBchB(Stellenbosch)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Naidoo", Varsity="MBchB(Ukzn)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Ngwenya ", Varsity="MBchB(UFS)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Miller", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Ronaldo ", Varsity="MBchB(Wits)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Buthelezi ", Varsity="MBchB(Stellenbosch)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Moodley", Varsity="MBchB(Ukzn)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Matsoso ", Varsity="MBchB(UP)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Ngcobo ", Varsity="MBchB(Stellenbosch)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Miller", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Xulu ", Varsity="MBchB(Wits)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Ronaldo ", Varsity="MBchB(UFS)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Moodley", Varsity="MBchB(Ukzn)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ DocName = "Dr Matsoso ", Varsity="MBchB(Stellenbosch)",ProfileImageURl="userplaceholder.png", IsVisible = false}
                };



            }
//This function must be removed
        public void HideOrShowProfile(DocAvaliable doctors)
        {
            if (_oldDoctorSelected == doctors)
            {
                // click twice on the same item will hide it
                doctors.IsVisible = !doctors.IsVisible;
                UpdateDoctorList(doctors);
            }
            else
            {
                if (_oldDoctorSelected != null)
                {
                    // hide previous selected item
                    _oldDoctorSelected.IsVisible = false;
                    UpdateDoctorList(_oldDoctorSelected);
                }
                // show selected item
                doctors.IsVisible = true;
                UpdateDoctorList(doctors);
            }

            _oldDoctorSelected = doctors;

        }
        //This function must be removed
        private void UpdateDoctorList(DocAvaliable doctors)
        {
            var index = Doctors.IndexOf(doctors);
            //updating method
            Doctors.Remove(doctors);
            //Or you can clear the list each time and just add everything back
            Doctors.Insert(index, doctors);

        }



            // Method below needs work, but can be found in ItemPage.xaml.cs
            //async Task ShowDoctorCommand()
            //{
            //    MessagingCenter.Send(this, "ThisDoctor", item);
            //    await Navigation.PushAsync(new AppoinmentView());
            //}

    }
    

    
        
}
