namespace flashcard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Card")]
    public partial class Card
    {
        [Key]
        public int ID_Card { get; set; }

        [Required]
        [StringLength(255)]
        public string Name_Card { get; set; }

        [Required]
        public string Description { get; set; }

        [StringLength(255)]
        public string Picture { get; set; }

        public DateTime Last_Modify { get; set; }

        public int Category_ID { get; set; }

        public int Level_ID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Level Level { get; set; }
    }
}
