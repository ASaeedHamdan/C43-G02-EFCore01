using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session01.Models
{
    internal class Department
    {

        [Key]
        public int DeptId { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(30)]
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
