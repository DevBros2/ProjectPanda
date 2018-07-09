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
	public partial class ChatBotView : ContentPage
	{
        ChatBotViewModel viewModel;

        public ChatBotView ()
		{
			InitializeComponent ();
            viewModel = new ChatBotViewModel();
            BindingContext = viewModel;
		}
	}
}