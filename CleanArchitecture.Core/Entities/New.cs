using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Entities
{
    public class New
    {
        [Key]
        public string? NewId { get; set; }
        public string? NewTitle { get; set; }
        public string? NewDescription { get; set;}
        public DateTime? NewDate { get; set; }
        public string? Author { get; set; }
    }
}
