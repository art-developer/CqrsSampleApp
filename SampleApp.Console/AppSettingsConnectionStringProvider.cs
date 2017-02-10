using System.Configuration;
using Art.Cqrs;

namespace SampleApp.Console
{
    class AppSettingsConnectionStringProvider:IConnectionStringProvider
    {
        public string ConnectionString {
            get { return ConfigurationManager.ConnectionStrings["Default"].ConnectionString; }
        }
    }
}
