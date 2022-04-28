namespace kursach_ConcertOrg111.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            ConcertOrganization = new HashSet<ConcertOrganization>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        public string Place { get; set; }

        public DateTime Time { get; set; }

        [Required]
        [StringLength(50)]
        public string GenersOfMusic { get; set; }

        public int Coast { get; set; }

        [Required]
        [StringLength(10)]
        public string ConcertOrganizationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConcertOrganization> ConcertOrganization { get; set; }
    }
}
