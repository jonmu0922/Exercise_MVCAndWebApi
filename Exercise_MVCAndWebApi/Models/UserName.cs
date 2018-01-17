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

        [Required(ErrorMessage = "帳號未輸入")]
        public string Account { get; set; }

        [Required(ErrorMessage = "密碼未輸入")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-zA-Z]).{6,20}$", ErrorMessage = "密碼格式錯誤")]
        public string Password { get; set; }

        [RegularExpression(@"^[09]{2}[0-9]{8}$", ErrorMessage = "手機格式錯誤")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Email未輸入")]
        [EmailAddress(ErrorMessage = "Email格式錯誤")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "Email格式錯誤")] //not working
        public string Email { get; set; }
    }
}