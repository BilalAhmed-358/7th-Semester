using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace IPTLAB_Task_02.Models
{
    public class UserModel
    {
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("age")]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Gender")]
        public string Gender { get; set; }
    }
}