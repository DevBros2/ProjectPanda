using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels.DeliveryViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.DeliveryViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MedicationSearch : ContentPage
	{
        //MedicationSearchViewModel viewModel;
        List<String> Medslist = new List<string>
        {
            "Drugs","","","","","","","","","","","","","","","","","","","","","","","","","",
        };

        public MedicationSearch ()
		{
			InitializeComponent ();
           // BindingContext = viewModel = new MedicationSearchViewModel();
		}

         void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var keyword = MedSearchBar.Text;
            
            //selects meds from where c is in the list.
            var suggestions = Medslist.Where(c => c.Contains(keyword));

            MedsListview.ItemsSource = suggestions;

        }
    }
}