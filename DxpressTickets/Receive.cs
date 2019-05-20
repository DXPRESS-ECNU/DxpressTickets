
using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace DxpressTickets
{
    public static class Receive
    {
        [FunctionName("Receive")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string requestBody = new StreamReader(req.Body).ReadToEnd();
            log.Info(requestBody);

            // TODO Decide what happen
            Message message = new Message(requestBody);
            Ticket ticket = message.DeTicket();
            ObjectResult result;
            switch (ticket.Type)
            {
                case Ticket.TicketType.Get:
                    result = HandleGet(ticket);
                    break;
                case Ticket.TicketType.Send:
                    result = HandleSend(ticket);
                    break;
                default:
                    result = new ObjectResult(new object());
                    break;
            }
            // TODO Write the return result;
            return result;
        }

        private static ObjectResult HandleSend(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        private static ObjectResult HandleGet(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
