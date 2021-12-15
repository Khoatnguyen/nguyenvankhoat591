using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nguyenvankhoat591.Models{
    [Table("CompanyNVK591")]
    public class CompanyNVK591 {
        [Key,StringLength(20),Display(Name =("id"))]
        public string  CompanyId { get; set; } = null!;

        [StringLength(50),Display(Name =("tên"))]
        public string CompanyName { get; set; } = null!;
    }
}