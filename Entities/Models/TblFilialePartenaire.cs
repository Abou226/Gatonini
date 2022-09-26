﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_filiale_partenaire")]
    public partial class TblFilialePartenaire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Contact { get; set; }
        public DateTime? Date_Ajout { get; set; }
        public string Auteur { get; set; }
        public string Siège { get; set; }
        public string Entreprise { get; set; }
    }
}