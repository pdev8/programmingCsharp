using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes.InterfacesAndExtensibility
{
    class DbMigrator
    {
        // Declare as readonly because once it's instantiated, we don't want to reinstantiate it
        private readonly ILogger _logger;

        // Specifying the dependencies
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }


        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            // Details of migrating the database

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
