using ProjectPanda.ViewModels.DeliveryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.CustomViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChatInputBarView : ContentView
	{
		public ChatInputBarView ()
		{
			InitializeComponent ();
            
		}

        public void Handle_Completed(object sender, EventArgs e)
        {
            (this.Parent.Parent.BindingContext as ChatbotViewModel2).OnSendCommand.Execute(null);
            chatTextInput.Focus();
        }

    }
}