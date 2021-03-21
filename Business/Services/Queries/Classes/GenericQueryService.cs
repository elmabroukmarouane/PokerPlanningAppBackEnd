using Business.Services.Queries.Interfaces;
using Infrastructure.Models.Classes;
using Infrastructure.Models.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.UnitOfWork.Interface;

namespace Business.Services.Queries.Classes
{
    public class GenericQueryService<TEntity> : IGenericQueryService<TEntity> where TEntity : Entity
    {
        #region ATTRIBUTES
        private IUnitOfWork<DatabaseContext> _unitOfWork;
        #endregion

        #region CONSTRUCTOR
        public GenericQueryService(IUnitOfWork<DatabaseContext> unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));
        }
        #endregion

        #region READ
        public async Task<IList<TEntity>> GetAllTEntitys()
        {
            return await _unitOfWork.GetRepository<TEntity>().GetAll();
        }

        public async Task<IList<TEntity>> GetTEntitys(
            Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includes = "", bool disableTracking = true,
            int take = 0, int offset = 0)
        {
            return await _unitOfWork.GetRepository<TEntity>().GetMuliple(
                predicate: predicate, orderBy: orderBy,
                includes: includes, disableTracking: disableTracking,
                take: take, offset: offset);
        }

        public async Task<TEntity> GetTEntityById(object id)
        {
            return await _unitOfWork.GetRepository<TEntity>().GetById(id);
        }

        public async Task<TEntity> GetFirstOrDefaultTEntity(
            Expression<Func<TEntity, bool>> predicate = null, 
            string includes = "", bool disableTracking = true)
        {
            return await _unitOfWork.GetRepository<TEntity>().GetFirstOrDefault(
                predicate: predicate, includes: includes,
                disableTracking: disableTracking);
        }

        public Task<IList<TEntity>> GetFromSqlRaw(
            string sql, params object[] parameters)
        {
            return _unitOfWork.GetRepository<TEntity>().FromSqlRaw(sql: sql, parameters: parameters);
        }
        #endregion

        #region OTHER
        public async Task<bool> TEntitysExist(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await _unitOfWork.GetRepository<TEntity>().Exists(predicate: predicate);
        }

        public async Task<int> CountTEntitys(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await _unitOfWork.GetRepository<TEntity>().Count(predicate: predicate);
        }
        #endregion
    }
}
