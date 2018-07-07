using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ProjectPanda.ViewModels.AppointmentViewModels;
using System.Windows.Input;

namespace ProjectPanda.Behaviors
{
    public class ItemSelectedBehavior : Behavior<ListView>
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(
                propertyName: "Command",
                returnType: typeof(ICommand),
                declaringType: typeof(ItemSelectedBehavior));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemSelected += BindableOnItemSelected;
            //subscribes to the changes
            bindable.BindingContextChanged += BindableOnBindingContextChanged;
        }

        private void BindableOnBindingContextChanged(object sender, EventArgs e)
        {
            var lv = sender as ListView;
            BindingContext = lv?.BindingContext;
        }

        private void BindableOnItemSelected(object sender, SelectedItemChangedEventArgs selectedItemChangedEventArgs)
        {
            Command.Execute(null); 
        }

        protected override void OnDetachingFrom(ListView bindable)//unsubscribing
        {
            base.OnDetachingFrom(bindable);
            bindable.ItemSelected -= BindableOnItemSelected;

            //UnSubscribes to the changes
            bindable.BindingContextChanged -= BindableOnBindingContextChanged;
        }
    }
}
