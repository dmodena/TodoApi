using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    [Table(name:"todoitem")]
    public class TodoItem
    {
        [Column(name:"id")]
        public long Id { get; set; }
        [Column(name:"name")]
        public string Name { get; set; }
        [Column(name:"iscomplete")]
        public bool IsComplete { get; set; }
    }
}
