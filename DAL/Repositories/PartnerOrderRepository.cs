namespace DAL.Data.Repositories
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using DAL.Data.DBContexts;
    using DAL.Data.Infrastructure;
    using BusinessEntities.Entity;
    using DAL.Data.Repositories.Interface;
    using DAL.Entities;

    public class PartnerOrderRepository : RepositoryBase<PartnerOrder>, IPartnerOrderRepository
    {
        private readonly MAC2000Context _dbContext;

        public PartnerOrderRepository(DbContext dbContext)
            : base(dbContext)
        {
            _dbContext = (_dbContext ?? (MAC2000Context)dbContext);
        }

        public void GetPartnerOrder(PartnerOrderEntity message)
        {

        }
        public IEnumerable<PartnerOrderEntity> GetPartnerOrders(int partnerId)
        {
            var partnerOrders = _dbContext.PartnerOrders
                                    .Where(x => x.PartnerID == partnerId)
                                    .Select(x => new PartnerOrderEntity()
                                    {
                                        OrderID = x.OrderID,
                                        SubOrderID = x.SubOrderID,
                                        TrackingNumber = x.TrackingNumber,
                                        CustomerName = x.CustomerName,
                                        CustomerMobile = x.CustomerMobile,
                                        Delivery_Zone = x.Delivery_Zone,
                                        Delivery_Street = x.Delivery_Street,
                                        Delivery_BuildingNo = x.Delivery_BuildingNo,
                                        Delivery_UnitNo = x.Delivery_UnitNo,
                                        Pickup_Zone = x.Pickup_Zone,
                                        Pickup_Street = x.Pickup_Street,
                                        Pickup_Building = x.Pickup_Building,
                                        Pickup_Unitno = x.Pickup_Unitno,
                                        Location_Details = x.Location_Details,
                                        DeliveryType = x.DeliveryType,
                                        DeliveryScheduletype = x.DeliveryScheduletype,
                                        ZoneType = x.ZoneType,
                                        ProductDiscription = x.ProductDiscription,
                                        Weight = x.Weight.Value,
                                        Quantity = x.Quantity.Value,
                                        CurrentStatus = x.CurrentStatus.Value,
                                        LastUpdateDate = x.LastUpdateDate,
                                        PartnerAuthCode = x.PartnerAuthCode,
                                        PartnerID = x.PartnerID.Value,
                                        RecordStatus = x.RecordStatus.Value,
                                    });

            return partnerOrders;
        }
    }
}