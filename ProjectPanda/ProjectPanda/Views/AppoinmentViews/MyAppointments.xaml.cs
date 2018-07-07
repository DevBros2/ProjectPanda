using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;
using ProjectPanda.Views;
using ProjectPanda.Views.AppoinmentViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyAppointments : ContentPage
	{
        
        MyAppointmentsViewModel viewmodel;
        private String _BasicString = "Doctor";
        

        public MyAppointments()
        {
            InitializeComponent();
            viewmodel = new MyAppointmentsViewModel();
            BindingContext = viewmodel;

            //subscribes(listens) for the item being sent from doctorlistViewModel 
            MessagingCenter.Subscribe<DoctorListView, string>(this, _BasicString, (sender, specialArgs) =>
            {
                //replaces string, using the OnPropertyChanged method in viewmodel
                viewmodel.MyAppointmentsViewModelText = specialArgs;
            });

        }
                   
    }
}