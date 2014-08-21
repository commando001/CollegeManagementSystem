//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace CollegeManagementSystem.DAL
{
    public class CollegeConfiguration : DbConfiguration
    {
        public CollegeConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}