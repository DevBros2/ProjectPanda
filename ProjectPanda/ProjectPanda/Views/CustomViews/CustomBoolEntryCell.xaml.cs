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
	public partial class CustomBoolEntryCell : ViewCell
	{
		public CustomBoolEntryCell ()
		{
			InitializeComponent ();
		}

        CustomBoolEntryCell switcher = new CustomBoolEntryCell();
        
    }
}