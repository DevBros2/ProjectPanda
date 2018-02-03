using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using ProjectPanda.Models;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{
    public class ChatBotViewModel : INotifyPropertyChanged
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
                OnPropertyChanged();

                //sendMessageCommand.ChangeCanExecute();
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
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
