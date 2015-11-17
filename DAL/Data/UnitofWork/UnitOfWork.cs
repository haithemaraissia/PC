using System;
using DAL.Data.Generic;
using Model;

namespace DAL.Data.UnitofWork
{
    public interface IUnitofWork : IDisposable
    {
        #region Model

        //Model
        IGenericRepository<Cooker> CookerRepository { get; }

        #endregion

        #region Save

        void Save();

        #endregion
    }
}
