using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Types.Abstract;
using TELMESSOS.ENTITIES.Entity;

namespace TELMESSOS.BUSINESS.Abstract
{
	public interface IUserService:IBaseService<User>
	{
		IDataResult<IEnumerable<User>> GetUsersByIds(IEnumerable<int> ids);
	}
}
