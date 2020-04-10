# Take.Chat.console

TAKE CHAT - CONSOLE E SERVER

** Descritivo Tecnico:  aplicação console desenvolvida em .NET com Framework .NET 4.7.2

1 - Para execução do chat, primeiramente acione o executavel Take.Chat.Server.exe.

2 - Após o Server estar ONLINE e exibir a mensagem que foi iniciado o monitoramento, pode ser executado os clients.

3 - Ao informar o Nickname aparecerá o menu com as informações de como utilizar a aplicação, conforme modelo abaixo:

 ** INSTRUÇÕES DE USO **                                                                                      
 Para enviar mensagem GERAL basta digitar a mensagem, ex.: >>> Olá Todos !                                    
 Para enviar mensagem PARA UM USUARIO, informe \"@U|nickname|Message\", ex.: >>> @U|admin_test| Olá admin     
 Para enviar mensagem PRIVADA A UM USUARIO, informe \"@P|nickname|Message\", ex.: >>> @P|admin_test| Olá amigo
 Para visualizar a lista de usuário ONLINE digite /L, ex.: >>> /L                                             
 Para SAIR do chat digite /X, ex.: >>> /X                                                                     
 Para VER o menu novamente digite /M a qualquer momento, ex.: >>> /M
 
** Divisão do Sistema / Arquitetura

a) Foram feitas 3 camadas para permitir um menor acoplamento da aplicação
b) Camada Take.Chat.Client é o chat para ser usado pelos Usuários
c) Camada Take.Chat.Server é o servidor que irá orquestrar as mensagens
d) Camada Take.Chat.Shared é um codigo compartilhado entre as duas outras camadas permitindo uma usabilidade melhor do código
