using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebBanHangOnline.Models.ClassModel
{
    [Table("tb_SystemSetting")]
    public class SystemSetting 
    {
        [Key]
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
        public string SettingDescription { get; set; }
    }
}