using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Take.Chat.Shared.Models;

namespace Take.Chat.Client.Interfaces
{
    public interface IExchangeServer
    {
        UserModel UserModel { get; set; }     
        Action SendUserToServerCallback { get; set; }
        void SendUser(string nickName);
        void FilterMessage(string message);
        void ReceiveMessage();

    }
}
