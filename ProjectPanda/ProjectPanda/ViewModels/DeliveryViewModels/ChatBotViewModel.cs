using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using ProjectPanda.Models;
using ProjectPanda.Utils;
using ProjectPanda.ViewModels.Base;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{
    public class ChatBotViewModel :BaseViewModel
    {
        private string messageText;

        public ObservableRangeCollection<ChatBotMessage> Messages { get;}

        public ICommand SendCommand { get; set; } 

        string outgoingText = string.Empty;

        public ChatBotViewModel()
        {
            Messages = new ObservableRangeCollection<ChatBotMessage>();

            SendCommand = new Command(() => {
                var message = new ChatBotMessage
                {
                    Message = OutGoingText,
                    Incoming = false,
                    TimeStamp=DateTime.Now
                };

                Messages.Add(message);

                OutGoingText = string.Empty;

            });

            InitializeMockData();

        }




        public void InitializeMockData()
        {
            Messages.ReplaceRange(new List<ChatBotMessage>
                {
                    new ChatBotMessage{ Message="All of Mine!", Incoming=true, TimeStamp=DateTime.Now},
                    new ChatBotMessage{Message="Chatbot reply", Incoming=false, TimeStamp=DateTime.Now.AddMinutes(23)},
                    new ChatBotMessage{Message="Get well soon!", Incoming=true, TimeStamp=DateTime.Now.AddSeconds(45)}
                });
        }

        public string OutGoingText
        {
            get
            {
                return outgoingText;
            }
            set
            {
                outgoingText = value;
                OnPropertyChanged("OutGoingText");

            }
        }

    }
}
