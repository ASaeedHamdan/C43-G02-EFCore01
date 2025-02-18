using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session01.Models
{
    internal class Topic
    {

        [Key]
        public int TopicId { get; set; }

        [Required]
        [MaxLength(300)]
        public string? Name { get; set; }
    }
}
