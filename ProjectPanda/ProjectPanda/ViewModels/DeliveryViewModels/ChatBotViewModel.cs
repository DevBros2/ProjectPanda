using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ProjectPanda.Models;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{
    public class ChatBotViewModel
    {
        public ObservableCollection<ChatBotMessage> PatientMessages { get; set; }

        public ObservableCollection<ChatBotMessage> AneleMessages { get; set; }

        public ChatBotViewModel()
        {
            GenaratePatientMessages();
            GenarateAneleMessages();
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



    }
}
