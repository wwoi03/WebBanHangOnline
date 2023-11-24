using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebBanHangOnline.Models.ClassModel
{
    [Table("tb_Contact")]
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống!")]
        [StringLength(150, ErrorMessage = "Không được vượt quá 150 ký tự!")]
        public string Name { get; set; }

        [StringLength(150, ErrorMessage = "Không được vượt quá 150 ký tự!")]
        public string Email { get; set; }
        public string Website { get; set; }

        [StringLength(5000, ErrorMessage = "Không được vượt quá 5000 ký tự!")]
        public string Massage { get; set; }
        public int IsRead { get; set; }
    }
}