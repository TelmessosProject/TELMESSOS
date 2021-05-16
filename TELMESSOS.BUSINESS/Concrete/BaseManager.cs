using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.BUSINESS.Abstract;
using TELMESSOS.CORE.Entities;
using TELMESSOS.CORE.Types.Abstract;
using TELMESSOS.CORE.Types.Concrete;
using TELMESSOS.DATAACCESS.Abstract;

namespace TELMESSOS.BUSINESS.Concrete
{
	public class BaseManager<TEntity> : IBaseService<TEntity> where TEntity:CoreEntity, new()
	{
		IBaseDal<TEntity> _baseDal;
		public BaseManager(IBaseDal<TEntity> baseDal)
		{
			_baseDal = baseDal;
		}
		public IResult Add(TEntity entity)
		{
			try
			{
				_baseDal.Insert(entity);
				return new SuccessResult();
			}
			catch (Exception e)
			{
				return new ErrorResult(e.Message);
			}
		}

		public IResult Add(IEnumerable<TEntity> entities)
		{
			try
			{
				_baseDal.Insert(entities);
				return new SuccessResult();
			}
			catch (Exception e)
			{
				return new ErrorResult(e.Message);
			}
		}

		public IResult Delete(int id)
		{
			try
			{
				_baseDal.Delete(new TEntity { Id = id });
				return new SuccessResult();
			}
			catch (Exception e)
			{
				return new ErrorResult(e.Message);
			}
		}

		public IResult Delete(IEnumerable<int> ids)
		{

			try
			{
				var deleteList=new List<TEntity>();
				foreach (var id in ids)
				{
					deleteList.Add(new TEntity {Id=id });
				}
				_baseDal.Delete(deleteList);

				return new SuccessResult();
			}
			catch (Exception e)
			{
				return new ErrorResult(e.Message);
			}
		}

		public IDataResult<IEnumerable<TEntity>> GetAll()
		{
			try
			{
				var result = _baseDal.GetAll();
				return new SuccessDataResult<IEnumerable<TEntity>>(result);
			}
			catch (Exception e)
			{
				return new ErrorDataResult<IEnumerable<TEntity>>(e.Message);
			}
		}

		public IDataResult<TEntity> GetById(int id)
		{
			try
			{
				var result= _baseDal.Get(x=> x.Id==id);
				return new SuccessDataResult<TEntity>(result);
			}
			catch (Exception e)
			{
				return new ErrorDataResult<TEntity>(e.Message);
			}
		}

		public IResult Update(TEntity entity)
		{
			try
			{
				_baseDal.Update(entity);
				return new SuccessResult();
			}
			catch (Exception e)
			{
				return new ErrorResult(e.Message);
			}
		}

		public IResult Update(IEnumerable<TEntity> entities)
		{
			try
			{
				_baseDal.Update(entities);
				return new SuccessResult();
			}
			catch (Exception e)
			{
				return new ErrorResult(e.Message);
			}
		}
	}
}
