using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Areas.Identity.Data
{
    public class TodoList
    {
        public int Id { get; set; }

        public int ToDoListUserId { get; set; }
        public virtual ToDoListUser User { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [StringLength(2, MinimumLength = 1)]
        public int Hour { get; set; }
    }
}
