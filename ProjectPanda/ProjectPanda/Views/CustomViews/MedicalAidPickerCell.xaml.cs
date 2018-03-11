using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels.SettingsViewModels;
using Xamarin.Forms.Internals;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.CustomViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [ContentProperty("Items")]
    public partial class MedicalAidPickerCell : ViewCell
    {
        private static readonly BindableProperty LabelProperty = BindableProperty.Create("MedicalAidLabel", typeof(string), typeof(MedicalAidPickerCell), default(string));

        private static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(MedicalAidPickerCell), default(string));

        private static readonly BindableProperty SelectedValueProperty = BindableProperty.Create("SelectedMedicalAid", typeof(string), typeof(MedicalAidPickerCell), null, BindingMode.TwoWay,

                    propertyChanged: (sender, oldValue, newValue) =>
                     {
                         MedicalAidPickerCell medicalaidpicker = (MedicalAidPickerCell)sender;

                         if (String.IsNullOrEmpty(newValue.ToString()))
                         {
                             medicalaidpicker.medicalaidTypePicker.SelectedIndex = -1;
                         }
                         else
                         {
                             medicalaidpicker.medicalaidTypePicker.SelectedIndex = medicalaidpicker.Items.IndexOf(newValue);
                         }

                     }

            );

        public MedicalAidPickerCell()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }

            set { SetValue(LabelProperty, value); }

        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string SelectedValue
        {
            get { return (string)GetValue(SelectedValueProperty); }
            set { SetValue(SelectedValueProperty, value); }
        }

        public IList<string> Items
        {
            get { return medicalaidTypePicker.Items; }
        }

        void OnMedicalAidPickerSelectedIndexChanged(object sender, EventArgs args)
        {

            if (medicalaidTypePicker.SelectedIndex == -1)
            {
                SelectedValue = null;
            }

            else
            {
                SelectedValue = Items[medicalaidTypePicker.SelectedIndex];
            }

        }

    }
}