﻿//using ProjectPanda.ViewModels.PaymentsViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaymentHistory : ContentPage
	{

       // PaymentViewModel viewModel;

        public PaymentHistory ()
		{
			InitializeComponent ();
           // viewModel = new PaymentViewModel();
          //  BindingContext = viewModel;
        }

    }

}