using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public DateTime SentAt { get; set; }
        public DateTime ReadAt { get; set; }
        public string Content { get; set; }

        public ICollection<UserMessage> Messages { get; set; }
    }
}
