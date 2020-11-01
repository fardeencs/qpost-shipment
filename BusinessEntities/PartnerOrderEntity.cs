namespace BusinessEntities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PartnerOrderEntity : BaseEntity<PartnerOrderEntity>
    {
        public string OrderID { get; set; }
        public string SubOrderID { get; set; }
        public string TrackingNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMobile { get; set; }
        public string Delivery_Zone { get; set; }
        public string Delivery_Street { get; set; }
        public string Delivery_BuildingNo { get; set; }
        public string Delivery_UnitNo { get; set; }
        public string Pickup_Zone { get; set; }
        public string Pickup_Street { get; set; }
        public string Pickup_Building { get; set; }
        public string Pickup_Unitno { get; set; }
        public string Location_Details { get; set; }
        public string DeliveryType { get; set; }
        public string DeliveryScheduletype { get; set; }
        public string ZoneType { get; set; }
        public string ProductDiscription { get; set; }
        public decimal Weight { get; set; }
        public int Quantity { get; set; }
        public int CurrentStatus { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string PartnerAuthCode { get; set; }
        public int PartnerID { get; set; }
        public int RecordStatus { get; set; }
        
    }
}
