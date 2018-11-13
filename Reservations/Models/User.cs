using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservations.Models
{
    public class User
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}