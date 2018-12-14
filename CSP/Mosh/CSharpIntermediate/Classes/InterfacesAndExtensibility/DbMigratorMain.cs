using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes.InterfacesAndExtensibility
{
    class DbMigratorMain
    {
        public static void Run()
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\test\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
