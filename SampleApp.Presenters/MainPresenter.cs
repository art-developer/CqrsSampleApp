﻿using SampleApp.IPresenters;
using SampleApp.IQueries;

namespace SampleApp.Presenters
{
    public class MainPresenter:IMainPresenter
    {
        private readonly IGetOrdersQuery getOrdersQuery;
        public MainPresenter(IGetOrdersQuery getOrdersQuery)
        {
            this.getOrdersQuery = getOrdersQuery;
        }

        public void Run()
        {
            var orders= getOrdersQuery.Execute();
        }
    }
}
