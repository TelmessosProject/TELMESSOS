using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.BUSINESS.Abstract;
using TELMESSOS.CORE.Types.Abstract;
using TELMESSOS.CORE.Types.Concrete;
using TELMESSOS.DATAACCESS.Abstract;
using TELMESSOS.ENTITIES.Entity;

namespace TELMESSOS.BUSINESS.Concrete
{
	public class UserManager : BaseManager<User>,IUserService
	{
		IUserDal _userDal;

		public UserManager(IUserDal userDal) : base(userDal)
		{
			_userDal = userDal;
		}

		public IDataResult<IEnumerable<User>> GetUsersByIds(IEnumerable<int> ids)
		{
			try
			{
				var result = _userDal.Select(x => ids.Contains(x.Id));
				return new SuccessDataResult<IEnumerable<User>>(result);
			}
			catch (Exception e)
			{
				return new ErrorDataResult<IEnumerable<User>>(e.Message) ;
			}
		}
	}
}
