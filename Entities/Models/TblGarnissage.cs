﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_garnissage")]
    public partial class TblGarnissage
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prix_Unité { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
    }
}