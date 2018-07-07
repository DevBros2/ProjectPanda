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
	public partial class DoctorListView : ContentPage
	{
        DoctorListViewModel viewmodel;
        public DocAvaliable DocAvaliable;
        private String _BasicString = "Doctor"; //a global string needs to be created

		public DoctorListView()
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


        

        private async void DoctorList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //simulates connection latency
            // await Task.Delay(4000);
            if (!(e.SelectedItem is DocAvaliable item))
                return;


            string listitem = item.DocName.ToString();
            // MessagingCenter.Send<AppointmentView,string>(this, _BasicString, listitem);
            //This sends the message of itemSelected
            MessagingCenter.Send(this, _BasicString, listitem);//This is the simple version

            await Navigation.PopToRootAsync();
           //await Navigation.PushAsync(new MyAppointments());
            DoctorList.SelectedItem = null;
        }
    }
    
}