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
        //public bool IsUser = false;
        public ChatbotDataSelector()
        {
            chatBotMessage = new DataTemplate(typeof(ChatBotMessage));
            userMessage = new DataTemplate(typeof(UserMessage));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = item as Models.ChatBotMessage;
            // There must be a loop here as each item is added to the list
            if (message.Incoming)
                return userMessage;
                 
            
            return chatBotMessage;
        }

        
    }
}
