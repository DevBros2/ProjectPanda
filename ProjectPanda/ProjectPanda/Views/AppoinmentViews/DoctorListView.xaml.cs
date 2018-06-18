using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;
using ProjectPanda.Services;
using ProjectPanda.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppointmentView : ContentPage
	{
        DoctorListViewModel viewmodel;
        public DocAvaliable DocAvaliable;
        private String _BasicString = "Doctor"; //a global string needs to be created

		public AppointmentView ()
		{
			InitializeComponent ();
           // DoctorList.On<Android>().SetIsFastScrollEnable(true);
           
            BindingContext = viewmodel = new DoctorListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //await RefreshItems();
        }


        private void DoctorList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = viewmodel;


            var doctors = e.Item as DocAvaliable;
            vm.HideOrShowProfile(doctors);
        }

        private async void DoctorList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //simulates connection latency
           // await Task.Delay(4000);

            var item = e.SelectedItem as DocAvaliable;
            if (item == null)
                return;

            string listitem = item.DocName.ToString(); 
            //This sends the message of itemSelected
            MessagingCenter.Send<AppointmentView,string>(this, _BasicString, listitem);

            await Navigation.PopToRootAsync();
           //await Navigation.PushAsync(new MyAppointments());
            DoctorList.SelectedItem = null;
        }
    }
    
}