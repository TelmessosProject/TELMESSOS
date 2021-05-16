using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Abstract;
using TELMESSOS.CORE.Entities;

namespace TELMESSOS.DATAACCESS.Abstract
{
    public interface IBaseDal<TEntity> : IRepository<TEntity> where TEntity : CoreEntity
    {

    }
}
