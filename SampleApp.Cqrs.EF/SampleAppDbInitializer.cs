using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Domain;

namespace SampleApp.Cqrs.EF
{
    public class SampleAppDbInitializer: DropCreateDatabaseAlways<SampleAppDbContext>
    {
        protected override void Seed(SampleAppDbContext context)
        {
            context.Add(new Order() {OrderId = 1, OrderNumber = "Num1"});
            context.Add(new Order() { OrderId = 2, OrderNumber = "Num2" });
            base.Seed(context);
        }
    }
}
