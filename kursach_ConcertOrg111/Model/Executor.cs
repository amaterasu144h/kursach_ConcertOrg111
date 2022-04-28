namespace kursach_ConcertOrg111.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Executor")]
    public partial class Executor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Executor()
        {
            ConcertOrganization = new HashSet<ConcertOrganization>();
        }

        [StringLength(10)]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Genres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConcertOrganization> ConcertOrganization { get; set; }
    }
}
