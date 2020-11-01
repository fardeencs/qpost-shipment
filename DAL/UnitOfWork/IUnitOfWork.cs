using System;
using System.Data.Entity;
using System.Threading.Tasks;
using DAL.Data.Infrastructure;
using DAL.Data.Repositories.Interface;
using DAL.Entities;

namespace DAL.Data.UnitOfWork
{
    public interface IUnitOfWork<U> where U : DbContext, IDisposable
    {
        int Commit();
        Task<int> CommitAsync();

        /// <summary>
        /// Repository intefaces
        /// </summary>
        IPartnerOrderRepository PartnerOrderRepository { get; }
        IPartnerRepository PartnerRepository { get; }

    }
}