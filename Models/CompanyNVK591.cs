using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nguyenvankhoat591.Models{

    public class CompanyNVK591 {
        [Key,StringLength(20)]
        public string  CompanyId { get; set; } = null!;

        [StringLength(50)]
        public string CompanyName { get; set; } = null!;
    }
}