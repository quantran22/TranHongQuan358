using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranHongQuan358.Models
{
    public class THQ358
    {
         [Key]
        [StringLength(20)]
        [Display(Name ="ID sv")]
        public string THQId { get; set; }
        [StringLength (50)]
        [Display(Name ="Tên sv")]
        public string THQName {get; set;}
        [Required]
        [Display(Name ="Giới tính")]
        public Boolean THQGender {get; set;}
    }
}