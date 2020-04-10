using System;
using System.Collections.Generic;
using System.Text;
using Take.Chat.Shared.Utils;

namespace Take.Chat.Shared.Msg
{
    public static class MessageConstants
    {    

        #region Messages

        public const string WELCOME_MSG = "Olá, Seja bem vindo ao Take Chat !";
        public const string USERNAME_MSG = "Informe seu NickName: ";
        public const string IP_USER_MSG = " IP: ";
        public const string ENTER_CHAT_MSG = "{0} Entrou no chat !";
        public const string EXIT_CHAT_MSG = "Saiu no chat !";
        public const string MONITORING_ENTER_MSG = "SERVIDOR ONLINE - Iniciando o monitoramento... !";
        public const string SUCCESS_CONECTED_MSG = "{0} - Registrado com sucesso !";
        public const string ADMIN_DEFAULT_MSG = Constants.ADMIN_NAME + ": {0}" ;
        public const string CLIENT_DEFAULT_MSG = "|{0} disse :| {1}";
        public const string PRIVATE_DEFAULT_MSG = "|PRIVADO - {0} disse para {1}:| {2}";
        public const string DIRECTED_DEFAULT_MSG = "|{0} disse para {1}:| {2}";


        #endregion

        #region Alerts

        public const string USER_ALREADY_EXISTS_ALT = "Esse usuário já existe, informe um nome diferente!";
        public const string USER_RESERVED_ALT = "Esse nome é reservado ao proprietário do chat ! Informe outro nome";
        public const string PRIVATE_MSG_WRONG_ALT = Constants.ADMIN_NAME+" : A mensagem privada está com padrão incorreto !";
        public const string DIRECT_MSG_WRONG_ALT = Constants.ADMIN_NAME + " : A mensagem direcionada a um usuário está com padrão incorreto !";
        public const string USER_NOT_FOUND_ALT = Constants.ADMIN_NAME + " : Usuário não encontrado ! Verifique se foi informado o nome correto !";

        #endregion

        #region Errors

        public const string NOT_CONNECTED_SERVER_ERR = "Não foi possível estabelecer uma conexão com o servidor! Tente mais tarde !";
        public const string START_LISTENER_CONN_ERR = "Ocorreu um problema ao inicializar o monitoramento ! ";
        public const string MONITOR_LISTENER_CONN_ERR = "A conexão não foi aceita ! ";
        public const string SEND_PRIVATE_MESSAGE_ERR = "Ocorreu um erro ao enviar uma mensagem privada ! Tente mais tarde";
        public const string USERS_LIST_ERR = "Ocorreu um erro ao exibir a lista de usuários !";

        #endregion

    }
}
