using ProjectPanda.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Lottie.Forms;

namespace ProjectPanda.ViewModels.SettingsViewModels
{
    public class AppointmentSetViewModel:BaseViewModel
    {
        
        public AppointmentSetViewModel()
        {
            Activate = new Command(async () => await ActivateUber());
            Deactivate = new Command(async () => await DeactivateUber());
        }

        public Command Activate { get; set; }

        public Command Deactivate { get; set; }

        int maxDistance;
        string status;
        string icon;
        Color colour=Color.DodgerBlue;
        Color colour2=Color.Gray;
        bool isPressed;

        public int MaxDistance
        {
            get
            {
                return maxDistance;
            }
            set
            {
                maxDistance = value;
                OnPropertyChanged("MaxDistance");
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        public string Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                OnPropertyChanged("Icon");
            }
        }

        public Color ButtonColour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
                OnPropertyChanged("ButtonColour");
            }
        }

        public Color ButtonColour2
        {
            get
            {
                return colour2;
            }
            set
            {
                colour2 = value;
                OnPropertyChanged("ButtonColour2");
            }
        }

        public bool IsPressedAlready
        {
            get
            {
                return isPressed;
            }
            set
            {
                isPressed = value;
                OnPropertyChanged("IsPressedAlready");
            }
        }

        #region Methods
        private async Task ActivateUber()
        {
            Status = "EnabledIcon.png";
            Icon = "uberLogo.png";
            ButtonColour = Color.DodgerBlue;
            ButtonColour2 = Color.Gray;
        }
        
        private async Task DeactivateUber()
        {
            Status = "DisabledIcon.png";
            Icon = "uberLogo.png";
            ButtonColour2 = Color.DodgerBlue;
            ButtonColour = Color.Gray;
        }

        #endregion
    }
}
