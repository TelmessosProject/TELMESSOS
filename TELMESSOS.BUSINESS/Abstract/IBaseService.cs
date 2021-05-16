using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Types.Abstract;

namespace TELMESSOS.BUSINESS.Abstract
{
	public interface IBaseService<TEntity>
	{
		IDataResult<IEnumerable<TEntity>> GetAll();
		IDataResult<TEntity> GetById(int id);
		IResult Add(TEntity entity);
		IResult Update(TEntity entity);
		IResult Delete(int id);
		IResult Add(IEnumerable<TEntity> entities);
		IResult Update(IEnumerable<TEntity> entities);
		IResult Delete(IEnumerable<int> ids);


	}
}
