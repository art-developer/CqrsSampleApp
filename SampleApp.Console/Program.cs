using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Art.Cqrs.EF;
using SampleApp.Cqrs.EF;
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
                var query = new GetOrdersQuery(new SampleAppUnitOfWork(new AppSettingsConnectionStringProvider()));
                var mainPresenter = new MainPresenter(query);
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
