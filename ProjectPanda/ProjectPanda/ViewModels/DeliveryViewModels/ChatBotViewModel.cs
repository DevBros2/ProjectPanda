using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using ProjectPanda.Models;
using ProjectPanda.ViewModels.Base;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{
    public class ChatBotViewModel :BaseViewModel, INotifyPropertyChanged
    {
        private string messageText;

        public ObservableCollection<ChatBotMessage> PatientMessages { get; set; }

        public ObservableCollection<ChatBotMessage> AneleMessages { get; set; }

        public ChatBotViewModel()
        {
            GenaratePatientMessages();
            GenarateAneleMessages();
        }


        public string MessageText
        {
            get
            {
                return messageText;
            }
            set
            {
                messageText = value;
                OnPropertyChanged("MessageText");

            }
        }

        private void GenaratePatientMessages()
        {
            PatientMessages = new ObservableCollection<ChatBotMessage>
            { 
            new ChatBotMessage{UserMessage ="Dummy Message" }

            };
        }

        private void GenarateAneleMessages()
        {
            PatientMessages = new ObservableCollection<ChatBotMessage>
            {
                new ChatBotMessage{UserMessage ="Dummy Message" }
            };

            

        }

        //implementing
        new public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            if(propertyName != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
