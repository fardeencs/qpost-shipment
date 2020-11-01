namespace DAL.Data.Repositories.Interface
{
    using System.Collections.Generic;
    using DAL.Data.Infrastructure;
    using DAL.Entities;
    using BusinessEntities.Entity;

    public interface IPartnerOrderRepository : IRepository<PartnerOrder>
    {
        void GetPartnerOrder(PartnerOrderEntity message);
        IEnumerable<PartnerOrderEntity> GetPartnerOrders(int partnerId);
    }
}