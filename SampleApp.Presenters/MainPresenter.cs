using SampleApp.IQueries;

namespace SampleApp.Presenters
{
    public class MainPresenter
    {
        private readonly IGetOrdersQuery getOrdresQuery;
        public MainPresenter(IGetOrdersQuery getOrdresQuery)
        {
            this.getOrdresQuery = getOrdresQuery;
        }

        public void Run()
        {
            var drugs= getOrdresQuery.Execute();
        }
    }
}
