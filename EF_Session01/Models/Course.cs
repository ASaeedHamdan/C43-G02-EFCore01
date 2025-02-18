using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session01.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(30)]
        [Column("CourseName",TypeName ="varchar")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(50)]
        public string Description { get; set; }
        public int Top_ID { get; set; }
    }
}
