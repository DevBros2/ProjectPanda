﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SupportPage : ContentPage
	{
		public SupportPage ()
		{
			InitializeComponent ();
            //removes the second Navbar 
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
	
}