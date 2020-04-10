using System;
using System.Collections.Generic;
using System.Text;

namespace Take.Chat.Shared.Ioc.Interfaces
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}
