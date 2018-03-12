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
        //60% of code needs to be moved to viewmodel
        MyAppointmentsViewModel _viewmodel;
        private String _BasicString = "Doctor";
        private String startDateLabel = "Date";

        public MyAppointments()
        {
            InitializeComponent();
            BindingContext = _viewmodel = new MyAppointmentsViewModel();

            //subscribes(listens) for the item being sent from doctorlistViewModel 
            MessagingCenter.Subscribe<AppointmentView, string>(this, _BasicString, (sender, specialArgs) =>
            {
                //replaces string, using the OnPropertyChanged method in viewmodel
                _viewmodel.MyAppointmentsViewModelText = specialArgs;

                
               
            });


            /* I have no idea how in the world this is implemented-khanyisani
            MessagingCenter.Subscribe<AppointmentView, string>(this, startDateLabel, (sender, someArg) => 
            {
                _viewmodel.DateTextLabel = someArg;
            });
            */

        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();
          
        }
       
        
        #region The select doctor and medical practice code
        private async void Doctor_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MedicalBuildingView());
        }
        #endregion

        
       

        #region Date picker event handler
         async private void Datepick(object sender, DateChangedEventArgs args)
        {
             string formatedDate;
           //formatedDate = TheDateForAppointment.Text = args.NewDate.ToString();
           // formatedDate = args.NewDate.ToShortDateString
          
        }
        #endregion

        #region Confirm and go to the next page
          async private void Confirm(object sender, EventArgs e)
        {


            try
            {
                //book the appointment
                //look for invalid entries 
                
            }
            catch
            {
                await DisplayAlert("Invalid Selection", "You have entred something incorrectly", "Cancel");
            }
            //This needs to use a diffrent navigation method
            finally
            {
                await Navigation.PushAsync(new ProblemEntryPage());
                // MessagingCenter.Unsubscribe<AppointmentView, string>(this, _BasicString);
            }

        }

        #endregion


        //dont know if we will use this
        private void Cancel(object sender, EventArgs e)
        {
           
        }


        
    }
}