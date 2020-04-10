using System;
using System.Net.Sockets;
using Take.Chat.Client.Interfaces;
using Take.Chat.Shared;
using Take.Chat.Shared.Msg;
using Take.Chat.Shared.Utils;

namespace Take.Chat.Client
{
    public class ManageClientConnection : IManageClientConnection
    {
        #region Properties
        
        public TcpClient TcpClient { get; set; }

        #endregion

        #region Methods    

        /// <summary>
        /// Create a TCP Connection
        /// </summary>
        public void Connect()
        {
            try
            {
                //initialize the tcp connection
                TcpClient = new TcpClient();
                TcpClient.Connect(Network.GetLocalIPAddress(), Constants.LAN_PORT);              
            }
            catch (Exception ex)
            {
                ChatLayout.PrintSimpleMessage(MessageConstants.NOT_CONNECTED_SERVER_ERR + "\n Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// Close a TCP Connection
        /// </summary>
        public void Disconnect()
        {
            TcpClient.Close();
        }

        #endregion

    }
}
