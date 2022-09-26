﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_elements")]
    public partial class TblElement
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Valeur { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
    }
}