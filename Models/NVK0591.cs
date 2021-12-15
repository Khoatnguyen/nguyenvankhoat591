using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nguyenvankhoat591.Models{
    [Table("NVK0591")]
    public class NVK0591 {
        [Key,StringLength(20),Display(Name = ("id"))]
        public string  NVKId { get; set; } = null!;

        [Required,StringLength(50),Display(Name =("Tên"))]
        public string NVKName { get; set; } = null!;

        [Required,Display(Name =("giới tính nam"))]
        public bool NVKGender{get;set;}
    }
}