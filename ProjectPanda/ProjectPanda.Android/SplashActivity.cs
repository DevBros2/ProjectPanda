using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ProjectPanda.Droid
{
    [Activity(Theme ="@style/Theme.Splash" , MainLauncher =true,NoHistory =true)]
    class SplashActivity :Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Creates your Application here
        }
        protected override void OnResume()
        {
            base.OnResume();
            Task startupwork = new Task(() => { SimulateStartup(); });
            startupwork.Start();
        }

        async void SimulateStartup()
        {
            await Task.Delay(200);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}