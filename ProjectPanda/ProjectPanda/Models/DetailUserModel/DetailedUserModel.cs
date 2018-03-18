using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ProjectPanda.ViewModels.DetailUserViewModels;
using ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo;

namespace ProjectPanda.Models
{
   

    public class DetailedUserModel: INotifyPropertyChanging
    {
        public bool hasDependencies;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
    }
}
