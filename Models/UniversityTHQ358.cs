using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoDotNetMVC.Models
{
    [Table("UniversityTHQ358s")]
     public class UniversityTHQ358 : StringProcessTHQ358 
    {
        [Key]
        [StringLength(20)]
        [Display(Name ="ID trường đại học")]
        public string UniversityId { get; set; }
        [StringLength (50)]
        [Display(Name ="Tên trường đại học")]
        public string UniversityName {get; set;}
        
    }
}