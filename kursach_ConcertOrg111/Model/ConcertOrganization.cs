namespace kursach_ConcertOrg111.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConcertOrganization")]
    public partial class ConcertOrganization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ld { get; set; }

        [Required]
        public string Name { get; set; }

        public int TicketId { get; set; }

        public int PriceId { get; set; }

        public int PlaceId { get; set; }

        public int GenersOfMusicId { get; set; }

        public DateTime TimeStart { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(10)]
        public string ExecutorId { get; set; }

        public DateTime TimeEnd { get; set; }

        public virtual Executor Executor { get; set; }

        public virtual Genres Genres { get; set; }

        public virtual GenresOfMusic GenresOfMusic { get; set; }

        public virtual Place Place { get; set; }

        public virtual Price Price1 { get; set; }

        public virtual Ticket Ticket { get; set; }

        public virtual UserTicket UserTicket { get; set; }
    }
}
