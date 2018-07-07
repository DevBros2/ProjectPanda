using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProjectPanda.NativeServices
{
    public interface IToolbarItemBadgeService
    {
        //Native Interface
        void SetBadge(Page page, ToolbarItem item, string value, Color BackgroundColor, Color textColor);
    }
}
