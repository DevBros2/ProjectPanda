using ProjectPanda.NativeServices;
using ProjectPanda.ViewModels.DeliveryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.DeliveryViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChatBotView2 : ContentPage
	{
		public ChatBotView2 ()
		{
			InitializeComponent ();
            this.BindingContext = new ChatbotViewModel2();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if(ToolbarItems.Count > 0)
            {
                DependencyService.Get<IToolbarItemBadgeService>().SetBadge(this, ToolbarItems.First(), $"{e.NewValue}", Color.LimeGreen, Color.White);
            }
        }
    }
}