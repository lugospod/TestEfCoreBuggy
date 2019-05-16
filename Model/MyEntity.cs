using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestEfCoreBuggy.Model
{
    [Table("my_entity")]
    public class MyEntity
    {
        [Column("id", Order = 1)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public MyOwnedEntity FirstOE { get; set; }
        public MyOwnedEntity SecondOE { get; set; }
    }
}
