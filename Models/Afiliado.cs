﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bossio_juancruz_lppa_recuperatorio.Models
{
    public class Afiliado: IdentityBase
    {
        [MaxLength(25)]
        public string Nombre { get; set; }
        [MaxLength(25)]
        public string Apellido { get; set; }
        [MaxLength(35)]
        public string Email { get; set; }
        public long Telefono { get; set; }
        public long CUIT { get; set; }
    }
}