using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using ProjectPanda.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using ProjectPanda.Views.CustomViews;
using CoreGraphics;

[assembly: ExportRenderer(typeof(ChatInputBarView), typeof(ChatEntryRenderer))]
namespace ProjectPanda.iOS
{
    public class ChatEntryRenderer : ViewRenderer
    {
        NSObject _keyboardShowObserver;
        NSObject _keyboardHideObserver;

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if(e.NewElement != null)
            {
                RegisterForKeyboardNotifications();
            }

            if(e.OldElement != null)
            {
                UnRegisterForKeyboardNotifications();
            }
        }

        private void UnRegisterForKeyboardNotifications()
        {
            if(_keyboardShowObserver != null)
            {
                _keyboardShowObserver.Dispose();
                _keyboardShowObserver = null;
            }
            if(_keyboardShowObserver != null)
            {
                _keyboardShowObserver.Dispose();
                _keyboardShowObserver = null;
            }
        }

        void RegisterForKeyboardNotifications()
        {
            if (_keyboardShowObserver == null)
                _keyboardShowObserver = UIKeyboard.Notifications.ObserveWillShow(OnKeyboardShow);
            if (_keyboardHideObserver == null)
                _keyboardHideObserver = UIKeyboard.Notifications.ObserveWillHide(OnKeyboardHide);
        }

         void OnKeyboardHide(object sender, UIKeyboardEventArgs e)
         {
            if(Element != null)
            {
                Element.Margin = new Thickness(0);//sets the margins to zero  when keyboard is dismissed
            }
         }

         void OnKeyboardShow(object sender, UIKeyboardEventArgs e)
         {
            NSValue result = (NSValue)e.Notification.UserInfo.ObjectForKey(new NSString(UIKeyboard.FrameEndUserInfoKey));
            CGSize keyboardSize = result.RectangleFValue.Size;
            
            if(Element != null)
                {
                Element.Margin = new Thickness(0, 0, 0, keyboardSize.Height);//push the entry up to keyboard height when keyboard is activated
            }

         }
        
    }
}