using System;
using System.Threading;
using Take.Chat.Client.Interfaces;
using Take.Chat.Shared;
using Take.Chat.Shared.Ioc;
using Take.Chat.Shared.Msg;
using Take.Chat.Shared.Utils;

namespace Take.Chat.Client
{
    public class ManageClient : IManageClient
    {
        #region Fields

        Thread _trhReceiveMessages;

        #endregion

        #region Properties

        private IExchangeServer _exchangeServer
        {
            get { return IocService.Locator.GetService<IExchangeServer>(); }
        }

        private IManageClientConnection _manageConnection
        {
            get { return IocService.Locator.GetService<IManageClientConnection>(); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Start the client chat
        /// </summary>
        public void InitializeChat()
        {
            //nickname
            ChatLayout.PrintSimpleMessage(MessageConstants.USERNAME_MSG);

            //set callback
            _exchangeServer.SendUserToServerCallback = InitializeChat;

            //send nickname to server
            _exchangeServer.SendUser(Console.ReadLine());

            //try connect to server
            if (_manageConnection.TcpClient.Connected)
            {
                //menu
                ChatLayout.PrintMenuChat();

                //set thread to receive messages
                _trhReceiveMessages = new Thread(new ThreadStart(_exchangeServer.ReceiveMessage));
                _trhReceiveMessages.Start();

                //filter messages and send to server
                while (_manageConnection.TcpClient.Connected)
                {
                    _exchangeServer.FilterMessage(Console.ReadLine());
                }              
            }
            else
            {
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Stop the client chat
        /// </summary>
        public void FinalizeChat()
        {
            _manageConnection.TcpClient.Close();
        }

        /// <summary>
        /// Show menu options
        /// </summary>
        public void ShowMenuChat()
        {
            ChatLayout.PrintMenuChat();
        }

        #endregion
    }
}
