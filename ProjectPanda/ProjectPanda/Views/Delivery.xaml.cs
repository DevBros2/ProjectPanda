using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Delivery : ContentPage
	{
		public Delivery ()
		{
			InitializeComponent ();


            NavigationPage.SetHasNavigationBar(this, true);
        }
	}
}