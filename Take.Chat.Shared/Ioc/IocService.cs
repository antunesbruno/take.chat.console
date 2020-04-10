using System;
using System.Collections.Generic;
using System.Text;
using Take.Chat.Shared.Ioc.Interfaces;

namespace Take.Chat.Shared.Ioc
{
    public static class IocService
    {
       public static IServiceLocator Locator { get; set; }
    }
}
