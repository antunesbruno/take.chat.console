using System;
using System.Collections.Generic;
using System.Text;
using Take.Chat.Shared.Ioc.Interfaces;

namespace Take.Chat.Shared.Ioc
{
    public class ServiceLocator : IServiceLocator
    {
        private IDictionary<object, object> _injectionServices;

        /// <summary>
        /// Connect the interface in your class. Ex.: Dictionary<interface, class>
        /// </summary>
        /// <param name="dependencies">Dictionary of dependencies</param>
        public ServiceLocator(IDictionary<object, object> dependencies)
        {
            _injectionServices = new Dictionary<object, object>();

            //fill the maps (interfaces and classes that will be used in takechat           
            foreach (var dependency in dependencies)
            {
                _injectionServices.Add(dependency);
            }        
        }

        public T GetService<T>()
        {
            try
            {
                return (T)_injectionServices[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("O serviço ou classe não foi instanciada ! Verifique as Injeções de Dependência !");
            }
        }
    }
}
