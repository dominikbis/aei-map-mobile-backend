using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Data
{
    public class AEIMapDbContextFactory : IDesignTimeDbContextFactory<AEIMapDbContext>
    {
        public AEIMapDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AEIMapDbContext>();
            optionsBuilder.UseSqlServer("Server=tcp:aeimap.database.windows.net,1433;Initial Catalog=aeimap;Persist Security Info=False;User ID=admin_aei;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return new AEIMapDbContext(optionsBuilder.Options);
        }
    }
}
