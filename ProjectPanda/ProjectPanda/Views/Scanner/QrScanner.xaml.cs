﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ProjectPanda.Services;

namespace ProjectPanda.Views.Scanner
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QrScanner : ContentPage
	{
		public QrScanner ()
		{
			InitializeComponent ();

            QrCodeScanner scan = new QrCodeScanner();
            scan.ReadQrCode();
        }





    }
}