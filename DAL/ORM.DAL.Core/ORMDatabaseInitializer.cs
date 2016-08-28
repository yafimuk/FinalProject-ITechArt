using System.Data.Entity;
using ORM.DAL.Core.Migrations;

namespace ORM.DAL.Core {
    class ORMDatabaseInitializer : MigrateDatabaseToLatestVersion<ApplicationContext, Configuration> {
    }
}
