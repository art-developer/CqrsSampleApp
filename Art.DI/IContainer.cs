using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art.DI
{
    public interface IContainer
    {
        void Register<TInterface, TImplementation>() where TImplementation : TInterface;
        TService Resolve<TService>();
    }
}
