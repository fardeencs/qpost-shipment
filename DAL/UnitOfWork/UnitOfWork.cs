namespace DAL.Data.UnitOfWork
{
    using System;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using DAL.Data.Infrastructure;
    using DAL.Data.Repositories;
    using DAL.Data.Repositories.Interface;
    using DAL.Entities;

    public class UnitOfWork<TContext> : Disposable, IUnitOfWork<TContext>
        where TContext : DbContext, new()
    {
        public virtual int Commit()
        {
            return _dataContext.SaveChanges();
        }

        public virtual Task<int> CommitAsync()
        {
            return _dataContext.SaveChangesAsync();
        }

        private readonly DbContext _dataContext;

        public UnitOfWork()
        {
            _dataContext = new TContext();
        }

        protected override void DisposeCore()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }

        /// <summary>
        /// Define Repositories
        /// </summary>

        private IPartnerOrderRepository _partnerOrderRepository;
        public IPartnerOrderRepository PartnerOrderRepository
        {
            get { return _partnerOrderRepository ?? (_partnerOrderRepository = new PartnerOrderRepository(_dataContext)); }
        }

        private IPartnerRepository _partnerRepository;
        public IPartnerRepository PartnerRepository
        {
            get { return _partnerRepository ?? (_partnerRepository = new PartnerRepository(_dataContext)); }
        }
    }
}