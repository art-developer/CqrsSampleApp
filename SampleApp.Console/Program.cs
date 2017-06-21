using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Art.Cqrs;
using Art.Cqrs.EF;
using Art.DI.LightInject;
using SampleApp.Cqrs.EF;
using SampleApp.IPresenters;
using SampleApp.IQueries;
using SampleApp.Presenters;
using SampleApp.Queries;

namespace SampleApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var container=new LightInjectContainer();
                container.Register<IUnitOfWork, SampleAppUnitOfWork>();
                container.Register<IGetOrdersQuery, GetOrdersQuery>();
                container.Register<IMainPresenter, MainPresenter>();
                container.Register<IConnectionStringProvider, AppSettingsConnectionStringProvider>();
                var mainPresenter = container.Resolve<IMainPresenter>();
                mainPresenter.Run();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }
        }
    }
}
