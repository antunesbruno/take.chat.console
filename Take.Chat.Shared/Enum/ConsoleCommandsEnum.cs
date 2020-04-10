using System;
using System.Collections.Generic;
using System.Text;

namespace Take.Chat.Shared.Enum
{
    public static class ConsoleCommandsEnum
    {
        /// <summary>
        /// Exit chat and close application
        /// </summary>
        public const string CONSOLE_NEW_USER = "/N";

        /// <summary>
        /// Exit chat and close application
        /// </summary>
        public const string CONSOLE_EXIT = "/X";

        /// <summary>
        /// Show de menu options
        /// </summary>
        public const string CONSOLE_MENU = "/M";

        /// <summary>
        /// Show de list of users connected
        /// </summary>
        public const string CONSOLE_USER_LIST = "/L";

        /// <summary>
        /// Identify that is a directed user message
        /// </summary>
        public const string CONSOLE_USER_MESSAGE = "@U";

        /// <summary>
        /// Identify that is a private message
        /// </summary>
        public const string CONSOLE_PRIVATE_MSG = "@P";
    }
}
