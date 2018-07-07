using ProjectPanda.Models;
using ProjectPanda.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{
    public class ChatbotViewModel2 : BaseViewModel
    {
        
        public ObservableCollection<ChatBotMessage> Messages { get; set; } = new ObservableCollection<ChatBotMessage>();
        public string TextToSend { get; set; }
        public ICommand OnSendCommand { get; set; }
        
        public ChatbotViewModel2()
        {
            Messages.Add(new ChatBotMessage() { Message = "Hi" });
            Messages.Add(new ChatBotMessage() { Message = "How Are You" });

            OnSendCommand = new Command(() =>
            {
                if (!string.IsNullOrEmpty(TextToSend))
                {
                    Messages.Add(new ChatBotMessage() { Message = TextToSend, User = App.User1 });
                    TextToSend = string.Empty;
                }
            });
        }
    }
}
