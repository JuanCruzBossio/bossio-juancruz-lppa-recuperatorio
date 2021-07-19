using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bossio_juancruz_lppa_recuperatorio.Models
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }
}