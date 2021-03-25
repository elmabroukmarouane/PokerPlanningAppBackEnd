using Business.Services.Commands.Interfaces;
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

namespace Business.Services.Commands.Classes
{
    public class GenericCommandService<TEntity> : IGenericCommandService<TEntity> where TEntity : Entity
    {
        #region ATTRIBUTES
        private IUnitOfWork<DatabaseContext> _unitOfWork;
        #endregion

        #region CONSTRUCTOR
        public GenericCommandService(IUnitOfWork<DatabaseContext> unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));
        }
        #endregion

        #region ADD

        public async Task<TEntity> InsertTEntity(TEntity TEntity)
        {
            TEntity.createdate = DateTime.Now;
            await _unitOfWork.GetRepository<TEntity>().Add(TEntity);
            await _unitOfWork.Save();
            return TEntity;
        }

        public async Task<IList<TEntity>> InsertTEntity(IList<TEntity> TEntitys)
        {
            foreach (var TEntity in TEntitys)
            {
                TEntity.createdate = DateTime.Now;
            }
            await _unitOfWork.GetRepository<TEntity>().Add(TEntitys);
            await _unitOfWork.Save();
            return TEntitys;
        }
        #endregion

        #region UPDATE

        public TEntity UpdateByStateTEntity(TEntity TEntity)
        {
            TEntity.updatedate = DateTime.Now;
            _unitOfWork.GetRepository<TEntity>().UpdateByState(TEntity);
            _unitOfWork.Save();
            return TEntity;
        }

        public TEntity UpdateTEntity(TEntity TEntity)
        {
            TEntity.updatedate = DateTime.Now;
            _unitOfWork.GetRepository<TEntity>().Update(TEntity);
            _unitOfWork.Save();
            return TEntity;
        }

        public IList<TEntity> UpdateTEntity(IList<TEntity> TEntitys)
        {
            foreach (var TEntity in TEntitys)
            {
                TEntity.updatedate = DateTime.Now;
            }
            _unitOfWork.GetRepository<TEntity>().Update(TEntitys);
            _unitOfWork.Save();
            return TEntitys;
        }

        public async Task<IList<TEntity>> UpdateByStateTEntity(IList<TEntity> TEntitys)
        {
            await _unitOfWork.GetRepository<TEntity>().UpdateByState(TEntitys);
            return TEntitys;
        }
        #endregion

        #region DELETE

        public async Task DeleteTEntity(object id)
        {
            await _unitOfWork.GetRepository<TEntity>().Delete(id);
            await _unitOfWork.Save();
        }

        public void DeleteTEntity(TEntity TEntity)
        {
            _unitOfWork.GetRepository<TEntity>().Delete(TEntity);
            _unitOfWork.Save();
        }

        public void DeleteTEntity(IList<TEntity> TEntitys)
        {
            _unitOfWork.GetRepository<TEntity>().Delete(TEntitys);
            _unitOfWork.Save();
        }
        #endregion
    }
}
