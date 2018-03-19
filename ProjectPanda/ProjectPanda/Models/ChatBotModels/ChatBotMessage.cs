using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    public class ChatBotMessage
    {
        public string UserMessage { get; set; }
        public string ChatbotMessage { get; set; }
        public string ConversationID { get; set; }
    }
}
