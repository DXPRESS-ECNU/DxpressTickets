﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DxpressTickets
{
    class Ticket
    {
        public TicketType Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime DeadLine { get; set; }
        public string Publisher { get; set; }
        public string UserId { get; set; }

        public enum TicketType
        {
            Get,
            Send
        }
    }
}
