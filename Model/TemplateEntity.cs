using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestEfCoreBuggy.Model
{
    /// <summary>
    /// Notification template.
    /// </summary>
    public class TemplateEntity    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Text { get; set; }

        public List<PartEntity> Parts { get; set; }
    }
}