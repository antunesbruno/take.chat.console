using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Take.Chat.Client.Interfaces
{
    public interface IManageClientConnection
    {
        TcpClient TcpClient { get; set; }
        void Connect();
        void Disconnect();
    }
}
