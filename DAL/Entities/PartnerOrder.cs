namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartnerOrder")]
    public partial class PartnerOrder
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string OrderID { get; set; }

        [StringLength(50)]
        public string SubOrderID { get; set; }

        [StringLength(50)]
        public string TrackingNumber { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(20)]
        public string CustomerMobile { get; set; }

        [StringLength(50)]
        public string Delivery_Zone { get; set; }

        [StringLength(50)]
        public string Delivery_Street { get; set; }

        [StringLength(50)]
        public string Delivery_BuildingNo { get; set; }

        [StringLength(50)]
        public string Delivery_UnitNo { get; set; }

        [StringLength(50)]
        public string Pickup_Zone { get; set; }

        [StringLength(50)]
        public string Pickup_Street { get; set; }

        [StringLength(50)]
        public string Pickup_Building { get; set; }

        [StringLength(50)]
        public string Pickup_Unitno { get; set; }

        [StringLength(150)]
        public string Location_Details { get; set; }

        [StringLength(50)]
        public string DeliveryType { get; set; }

        [StringLength(50)]
        public string DeliveryScheduletype { get; set; }

        [StringLength(50)]
        public string ZoneType { get; set; }

        [StringLength(200)]
        public string ProductDiscription { get; set; }

        public decimal? Weight { get; set; }

        public int? Quantity { get; set; }

        public int? CurrentStatus { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        [StringLength(100)]
        public string PartnerAuthCode { get; set; }

        public int? PartnerID { get; set; }

        public int? RecordStatus { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Createduser { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedUser { get; set; }
    }
}
