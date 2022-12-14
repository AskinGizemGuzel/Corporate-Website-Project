using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    [Table("İletisim")]
    public class İletisim
    {
        [Key]
        public int İletisimId { get; set; }
        [StringLength(250,ErrorMessage ="250 Karakter Olmalıdır!")]
        public string Adres { get; set; }
        [StringLength(10, ErrorMessage = "10 Karakter Olmalıdır!")]
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Whatsapp { get; set; }
        public string Instagram { get; set; }


    }
}