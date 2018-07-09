using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;

namespace ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchMedicalCondition : ContentPage
    {
        #region Variables

        //embedded file with all the medication
        string medicationTextFile;
        int maxMatches;
        string resourceFilePath = "ProjectPanda.Texts.medication.txt";
        #endregion

        #region Default Constructor
        public SearchMedicalCondition ()
		{
			InitializeComponent ();

            //The Line for creating an instance for reading the file from the embedded resource folder Texts
            Assembly assembly = GetType().GetTypeInfo().Assembly;

            //gets the file in use
            using (Stream streamPathway = assembly.GetManifestResourceStream(resourceFilePath))
            {
                using(StreamReader reader=new StreamReader(streamPathway))
                {
                    medicationTextFile = reader.ReadToEnd();
                }
            }
        }
        #endregion

        #region Methods

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            scrollResult.Content = null;

            medicationSearchResult.Children.Clear();
            SearchFileForMedication(searchResult.Text);

            scrollResult.Content = medicationSearchResult;
        }


        void SearchFileForMedication(string searchMedication)
        {
            int numOfMedication = 0;
            bool isTruncated = false;

            #region using statement for reading the text file
            
            using(StringReader read=new StringReader(medicationTextFile))
            {
                string nameOfMedication;
              
                while(null != (nameOfMedication = read.ReadLine()))
                {
                    //code To do the search
                    //-1 is used cause the indexer starts at zero and that yeilds a result from 0-infinty
                    int index = 0;

                    while (-1 !=(index=(nameOfMedication.IndexOf(searchMedication, index, StringComparison.OrdinalIgnoreCase))))
                    {

                        if (numOfMedication >= maxMatches)
                        {
                            isTruncated = true;
                            break;
                        }
                        index++;

                        //add the search results information to the StackLayout 
                       medicationSearchResult.Children.Add(new Label {

                            //Display the text from the result of the text file
                            Text=String.Format("Oh Well display the figures here")
                        });
                             
                    }

                }
               
            }
          
            #endregion 
        }

        private void SearchBarTextChanged(object sender, TextChangedEventArgs args)
        {
            medicationSearchResult.Children.Clear();
        }
        #endregion
    }
}