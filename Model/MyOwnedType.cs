using System.ComponentModel.DataAnnotations;

namespace TestEfCoreBuggy.Model
{
    public class MyOwnedEntity
    {
        public int? CodebookId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
    }
}