using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class UserMessage
    {
        public int ID { get; set; }  
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }

        public virtual User SenderUser { get; set; }
        public virtual User ReceiverUser { get; set; }
        public virtual Message Message { get; set; }

    }
}
