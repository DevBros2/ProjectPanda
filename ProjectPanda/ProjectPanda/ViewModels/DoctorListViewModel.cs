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
                    new DocAvaliable{ Name = "Dr Zulu ", Varsity="MBchB(Ukzn)",ProfileImageURl="userplaceholder.png" , IsVisible = false},
                    new DocAvaliable{ Name = "Dr Duma ", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ Name = "Dr Moody ", Varsity="MBchB(Wits)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ Name = "Dr McGhee ", Varsity="MBchB(Stellenbosch)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ Name = "Dr Naidoo", Varsity="MBchB(Ukzn)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ Name = "Dr Ngwenya ", Varsity="MBchB(UFS)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ Name = "Dr Miller", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ Name = "Dr Ronaldo ", Varsity="MBchB(Wits)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ Name = "Dr Buthelezi ", Varsity="MBchB(Stellenbosch)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ Name = "Dr Moodley", Varsity="MBchB(Ukzn)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ Name = "Dr Matsoso ", Varsity="MBchB(UP)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ Name = "Dr Ngcobo ", Varsity="MBchB(Stellenbosch)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ Name = "Dr Miller", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ Name = "Dr Xulu ", Varsity="MBchB(Wits)",ProfileImageURl="userplaceholder.png", IsVisible = false},
                    new DocAvaliable{ Name = "Dr Ronaldo ", Varsity="MBchB(UFS)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ Name = "Dr Moodley", Varsity="MBchB(Ukzn)",ProfileImageURl="userplaceholder.png",IsVisible = false},
                    new DocAvaliable{ Name = "Dr Matsoso ", Varsity="MBchB(Stellenbosch)",ProfileImageURl="userplaceholder.png", IsVisible = false}
                };



            }

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
