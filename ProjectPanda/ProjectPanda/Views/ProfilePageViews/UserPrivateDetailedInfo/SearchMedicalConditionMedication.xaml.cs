using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchMedicalCondition : ContentPage
    {
        #region Variables

        //embedded file with all the medication
        string medicationTextFile;
        double maxMatches;

        string resourceFilePath = "medication.txt";
        #endregion

        

        

        public SearchMedicalCondition ()
		{
			InitializeComponent ();
		}


        #region Methods

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            scrollResult.Content = null;

            medicationSearchResult.Children.Clear();

        }


        void SearchFileForMedication(string searchMedication)
        {
            int numOfMedication = 0;
            bool isTruncated = false;

            #region using statement
            /*
            using(StringReader read=new StringReader(medicationTextFile))
            {
                string nameOfMedication;

               
            }
          */
            #endregion 
        }

        private void SearchBarTextChanged(object sender, TextChangedEventArgs args)
        {
            medicationSearchResult.Children.Clear();
        }
        #endregion
    }
}