using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Custom
{
    public class EmailAdreess
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class EmailMessage
    {
        public EmailMessage()
        {
            ToAddresses = new List<EmailAdreess>();
            FromAddresses = new List<EmailAdreess>();
        }

        public List<EmailAdreess> ToAddresses { get; set; }
        public List<EmailAdreess> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
