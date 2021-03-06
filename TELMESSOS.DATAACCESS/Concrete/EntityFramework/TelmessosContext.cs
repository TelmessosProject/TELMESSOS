using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Helper;
using TELMESSOS.ENTITIES.Entity;

namespace TELMESSOS.DATAACCESS.Concrete.EntityFramework
{
    public class TelmessosContext:DbContext
    {
		
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Telmessos;Integrated Security=True");
			optionsBuilder.UseSqlServer(ConnectionHelper.GetConnectionString("TelmessosConnection"));


		}

		#region tables
		public DbSet<User> Users { get; set; }
		#endregion

	}



}
