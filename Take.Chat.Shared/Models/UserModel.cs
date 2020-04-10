using System;
using System.Collections.Generic;
using System.Text;

namespace Take.Chat.Shared.Models
{
    public class UserModel
    {
        public string NickName { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public DateTime EnterDate { get; set; }
    }
}
