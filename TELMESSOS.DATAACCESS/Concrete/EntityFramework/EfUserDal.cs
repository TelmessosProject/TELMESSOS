using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Concrete.EntityFramework;
using TELMESSOS.DATAACCESS.Abstract;
using TELMESSOS.ENTITIES.Entity;

namespace TELMESSOS.DATAACCESS.Concrete.EntityFramework
{
	public class EfUserDal : EfRepository<User, TelmessosContext>,IUserDal
	{
		
	}
}
