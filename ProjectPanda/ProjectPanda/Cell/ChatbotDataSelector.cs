using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ProjectPanda.Models;

namespace ProjectPanda.Cell
{
     class ChatbotDataSelector : DataTemplateSelector 
    {
        readonly DataTemplate chatBotMessage, userMessage;
        DataTemplate incomingDataTemplate,outDataTemplate;
        //public bool IsUser = false;
        public ChatbotDataSelector()
        {
            //chatBotMessage = new DataTemplate(typeof(ChatBotMessage));
            //userMessage = new DataTemplate(typeof(UserMessage));
            incomingDataTemplate = new DataTemplate(typeof(IncomimgMessage));
            outDataTemplate = new DataTemplate(typeof(OutgoingViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = item as Models.ChatBotMessage;
            // There must be a loop here as each item is added to the list
            //if (message.Incoming)
            //  return userMessage;
            if (message == null)
                return null;
            
            return (message.User == App.User1)? outDataTemplate : incomingDataTemplate;
        }

        
    }
}
