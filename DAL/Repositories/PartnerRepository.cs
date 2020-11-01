namespace DAL.Data.Repositories
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using DAL.Data.DBContexts;
    using DAL.Data.Infrastructure;
    using BusinessEntities;
    using DAL.Data.Repositories.Interface;
    using DAL.Entities;
    public class PartnerRepository : RepositoryBase<Partner>, IPartnerRepository
    {
        private readonly MAC2000Context _dbContext;

        public PartnerRepository(DbContext dbContext)
            : base(dbContext)
        {
            _dbContext = (_dbContext ?? (MAC2000Context)dbContext);
        }
    }
}
