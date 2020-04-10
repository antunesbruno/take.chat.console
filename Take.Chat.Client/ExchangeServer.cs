using System;
using System.IO;
using Take.Chat.Client.Interfaces;
using Take.Chat.Shared;
using Take.Chat.Shared.Enum;
using Take.Chat.Shared.Ioc;
using Take.Chat.Shared.Models;
using Take.Chat.Shared.Msg;
using Take.Chat.Shared.Utils;

namespace Take.Chat.Client
{
    public class ExchangeServer : IExchangeServer
    {
        #region Fields

        private StreamWriter _strSender;
        private StreamReader _strReceiver;

        #endregion

        #region Properties

        public UserModel UserModel { get; set; }
        public Action SendUserToServerCallback { get; set; }

        private IManageClientConnection _manageConnection
        {
            get { return IocService.Locator.GetService<IManageClientConnection>(); }
        }

        private IManageClient _manageClient
        {
            get { return IocService.Locator.GetService<IManageClient>(); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Send the new user to server
        /// </summary>
        /// <param name="nickName"></param>
        public void SendUser(string nickName)
        {
            //instance model
            UserModel = new UserModel();

            //connect
            _manageConnection.Connect();

            //send nickname to server
            if (_manageConnection.TcpClient.Connected)
            {
                _strSender = new StreamWriter(_manageConnection.TcpClient.GetStream());
                _strSender.WriteLine(nickName);
                _strSender.Flush();

                //set nickname at the model
                UserModel.NickName = nickName;
            }
            else
            {
                SendUserToServerCallback.Invoke();
            }
        }
        
        /// <summary>
        /// Receive message from server
        /// </summary>
        public void ReceiveMessage()
        {
            //receive the server message
            _strReceiver = new StreamReader(_manageConnection.TcpClient.GetStream());

            //receive response
            string[] response = _strReceiver.ReadLine().Split(Constants.ESCAPE_SPLIT_MSG);

            if (response.Length >= 2)
            {
                //print error message
                ChatLayout.PrintSimpleMessage(string.Format(MessageConstants.ADMIN_DEFAULT_MSG, response[1]));

                //reinitialize
                _manageClient.InitializeChat();
            }
            else
            {
                //print the line of receiver
                ChatLayout.PrintSimpleMessage(response[0]);

                //is connected
                while (_manageConnection.TcpClient.Connected)
                {
                    // exibe mensagems no Textbox                
                    ChatLayout.PrintSimpleMessage(_strReceiver.ReadLine());
                }
            }
        }

        /// <summary>
        /// Send messages to server
        /// </summary>
        /// <param name="message"></param>
        private void SendMessage(string message)
        {          
            _strSender.WriteLine(message);
            _strSender.Flush();
        }

        /// <summary>
        /// Filter the message sending to server only its needed
        /// </summary>
        /// <param name="message"></param>
        public void FilterMessage(string message)
        {
            switch (message.ToUpper())
            {
                case ConsoleCommandsEnum.CONSOLE_EXIT:
                    {
                        //exit console
                        _manageClient.FinalizeChat();
                        break;
                    }
                case ConsoleCommandsEnum.CONSOLE_MENU:
                    {
                        //show menu
                        _manageClient.ShowMenuChat();
                        break;
                    }
                default:
                    {
                        //send message to server
                        SendMessage(message);
                        break; 
                    }
            }
        }

        #endregion
    }
}
