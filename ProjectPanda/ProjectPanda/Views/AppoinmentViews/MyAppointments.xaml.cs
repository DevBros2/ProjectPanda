using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;
using ProjectPanda.Views.PopUpPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyAppointments : ContentPage
	{
        MyAppointmentsViewModel _viewmodel;

		public MyAppointments ()
		{
			InitializeComponent ();

            BindingContext = _viewmodel = new MyAppointmentsViewModel();
		}



        #region The select doctor and medical practice code
        private async void Doctor_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MedicalBuildingView());
        }
        #endregion

       

        #region Date picker event handler
        private void Datepick(object sender, DateChangedEventArgs args)
        {
             string formatedDate;
             formatedDate= TheDateForAppointment.Text = args.NewDate.ToString();
        }
        #endregion

        #region Confirm code
        private void Confirm(object sender, EventArgs e)
        {
            //going to be moved else where
            //code to confirm the appointemnt 
            XFFlipViewControl1.IsFlipped = !XFFlipViewControl1.IsFlipped;
        }

        #endregion


        //dont know if we will use this
        private void Cancel(object sender, EventArgs e)
        {
           
        }


        #region Pop Up code
        async private void NextPage(object sender, EventArgs e)
        {
            //This needs to use a diffrent navigfation method
            await Navigation.PushAsync(new ProblemMessage());
        }
        #endregion
    }
}