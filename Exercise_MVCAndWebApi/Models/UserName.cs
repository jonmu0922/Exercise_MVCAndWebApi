using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise_MVCAndWebApi.Models
{
    public class UserModel
    {
        [DisplayName("姓名")]
        [Required(ErrorMessage = "姓名未輸入")]
        public string Name { get; set; }


        [DisplayName("年齡")]
        [Required(ErrorMessage = "年齡未輸入")]
        [Range(0, 150, ErrorMessage = "年齡超過限制 0 ~ 150 之間")]
        public int Age { get; set; }
    }
}