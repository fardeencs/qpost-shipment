namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partner")]
    public partial class Partner
    {
        public int PartnerID { get; set; }

        [StringLength(100)]
        public string PartnerAuthCode { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(100)]
        public string ContactPerson { get; set; }

        [StringLength(20)]
        public string ContactTelephone { get; set; }

        [StringLength(100)]
        public string WebSite { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string API { get; set; }

        public int? RecordStatus { get; set; }

        public DateTime? Createddate { get; set; }

        public int? CreatedUser { get; set; }

        public DateTime? Modifieddate { get; set; }

        public int? ModifiedUser { get; set; }
    }
}
