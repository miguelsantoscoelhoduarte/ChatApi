using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<UserMessage> SenderMessages { get; set; }

        public ICollection<UserMessage> ReceiverMessages { get; set; }
    }
}
