using System;
using System.Collections.Generic;
using System.Text;
using Take.Chat.Shared.Msg;

namespace Take.Chat.Shared
{
    public static class ChatLayout
    {
        public static void PrintWelcome(string msgComplement = null)
        {
            Console.WriteLine("*=====================================================================*");
            Console.WriteLine("* "+ MessageConstants.WELCOME_MSG + msgComplement);
            Console.WriteLine("*=====================================================================*");
        }

        public static void PrintSimpleMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
        }

        public static void PrintAlert(string message = null)
        {
            Console.WriteLine();
            Console.WriteLine("***** " + message + " *****");
        }

        public static void PrintEnterChat(string nickname, string ip)
        {
            Console.WriteLine();
            Console.WriteLine("\"" + nickname + "\"" + MessageConstants.IP_USER_MSG + "\"" + ip + "\" " + MessageConstants.ENTER_CHAT_MSG);
        }

        public static void PrintExitChat(string nickname, string ip)
        {
            Console.WriteLine();
            Console.WriteLine("\"" + nickname + "\"" + MessageConstants.IP_USER_MSG + "\"" + ip + "\" " + MessageConstants.EXIT_CHAT_MSG);
        }

        public static void PrintMenuChat()
        {
            Console.WriteLine();                         
            Console.WriteLine("|=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/|");
            Console.WriteLine("| ** INSTRUÇÕES DE USO **                                                                                          |");
            Console.WriteLine("| Para enviar mensagem GERAL basta digitar a mensagem, ex.: >>> Olá Todos !                                        |");
            Console.WriteLine("| Para enviar mensagem PARA UM USUARIO, informe \"@U|nickname|Message\", ex.: >>> @U|admin_test| Olá admin         |");
            Console.WriteLine("| Para enviar mensagem PRIVADA A UM USUARIO, informe \"@P|nickname|Message\", ex.: >>> @P|admin_test| Olá amigo    |");
            Console.WriteLine("| Para visualizar a lista de usuário ONLINE digite /L, ex.: >>> /L                                                 |");
            Console.WriteLine("| Para SAIR do chat digite /X, ex.: >>> /X                                                                         |");
            Console.WriteLine("| Para VER o menu novamente digite /M a qualquer momento, ex.: >>> /M                                              |");
            Console.WriteLine("|=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/= |");
            Console.WriteLine("");
        }
    }
}
