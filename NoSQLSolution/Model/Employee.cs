using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public ObjectId _id { get; set; }
        public int Id;
        public string Email;
        public string Firstname;
        public string Lastname;
        public int NrOfTickts;
        public string Username;
        public string Password;
        public UserType UserType;
    }
}
