using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using ProjectPanda.Droid;
using ProjectPanda.Views.CustomEntry;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

namespace ProjectPanda.Droid
{

   [Assembly: Xamarin.Forms.ExportRenderer(typeof(EntryBlock),  typeof(RoundedEntryAndroid))]
    public class RoundedEntryAndroid : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

          
        }
    }
}