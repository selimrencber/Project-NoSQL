using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public ObjectId _id { get; set; }
        public int Id;
        public Employee User;
        public DateTime Date;
        public TicketPriority Priority;
        public DateTime Deadline;
        public string Description;
    }
}
