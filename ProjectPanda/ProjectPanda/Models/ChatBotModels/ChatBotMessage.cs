using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectPanda.Models
{
    public class ChatBotMessage
    {
        
        public string Message { get; set; }

        public DateTime TimeStamp { get; set; }

        public bool Incoming { get; set; }
    }
}
