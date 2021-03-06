﻿using System;
using Microsoft.WindowsAzure.MobileServices;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SQLitePCL.lib;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using SQLitePCL.Extensions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using ZXing.Net.Mobile.Forms;
using Xamarin.Forms.Platform.Android;
using Lottie.Forms.Droid;
using Rg.Plugins.Popup;
using Rg.Plugins.Popup.Animations;
using System.IO;

namespace ProjectPanda.Droid
{
    [Activity(Label = "ProjectPanda", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.Tabbar;
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

           

            // This MobileServiceClient has been configured to communicate with the Azure Mobile App and
            // Azure Gateway using the application url. You're all set to start working with your Mobile App!
            Microsoft.WindowsAzure.MobileServices.MobileServiceClient ProjectPandaClient = new Microsoft.WindowsAzure.MobileServices.MobileServiceClient(
            "https://projectpanda.azurewebsites.net");

            //auth code for android
            global::Xamarin.Auth.Presenters.XamarinAndroid.AuthenticationConfiguration.Init(this, bundle);


            

            global::Xamarin.Forms.Forms.Init(this, bundle);
            //Calender view code
            XamForms.Controls.Droid.Calendar.Init();

            //Lottie Animation android code
            AnimationViewRenderer.Init();

            #region Local database for android devices
            string dbName = "userSettingsdb.sqlite";
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(folderPath, dbName);
            #endregion 


            LoadApplication(new ProjectPanda.App(fullPath));


        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}

