using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using ProjectPanda.Views;
using ProjectPanda.Views.CustomEntry;

namespace ProjectPanda.Views.CustomEntry
{


    public class EntryBlock:Editor
    {

        public static BindableProperty PlaceholderProperty =
            BindableProperty.Create(nameof(Placeholder2), typeof(string), typeof(EntryBlock));

        public static BindableProperty PlaceholderColorProperty =
            BindableProperty.Create(nameof(PlaceholderColor2), typeof(Color), typeof(EntryBlock), Color.Black);

        public string Placeholder2
        {
            get { return (string)GetValue(PlaceholderProperty); }

            set { SetValue(PlaceholderProperty, value); }
        }


        public Color PlaceholderColor2
        {
            get { return (Color)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }


    }
}
