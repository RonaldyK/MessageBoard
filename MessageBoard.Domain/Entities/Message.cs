using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Domain.Entities
{
    public class Message
    {
        [Key]
        public int Id { set; get; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title can't be longer then 100 characters")]
        public string Title { set; get; }
        
        [StringLength(500)]
        public string Caption { set; get; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { set; get; } = DateTime.Now;
        
    }
}
