using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using ProjectPanda.Views.CustomEntry;
using ProjectPanda.iOS;

[assembly:ExportRenderer(typeof(EntryBlock), typeof(RoundedEntryIOS))]
namespace ProjectPanda.iOS
{
    public class RoundedEntryIOS : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 8;
                Control.Layer.BorderWidth = 2f;
                Control.BackgroundColor = Color.White.ToUIColor();
                
            }
        }
    }
}