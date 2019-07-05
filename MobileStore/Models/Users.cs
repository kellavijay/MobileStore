using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Models
{
    public class Users
    {
        [Key]
        public int uId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Name Can not exceed 50 Characters")]
        public string uName { get; set; }
        [Required]
        public string userType { get; set; }
        public string uProfileImageUrl { get; set; }
        [Required]
        public Double MobileNumber { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Invalid Email Format")]
        public string uEmail { get; set; }

    }
}
