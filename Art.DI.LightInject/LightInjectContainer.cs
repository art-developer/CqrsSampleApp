using System;
using System.Linq.Expressions;
using LightInject;


namespace Art.DI.LightInject
{
    public class LightInjectContainer : IContainer
    {
        private readonly ServiceContainer container = new ServiceContainer();

        public void Register<TInterface, TImplementation>() where TImplementation:TInterface
        {
            container.Register<TInterface, TImplementation>();
        }

        public TService Resolve<TService>()
        {
            return container.GetInstance<TService>();
        }
    }
}
