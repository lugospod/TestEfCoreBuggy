using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestEfCoreBuggy.Model
{
    public class PartEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long? TemplateId { get; set; }
        public TemplateEntity Template { get; set; }
        public string Text { get; set; }
    }
}
