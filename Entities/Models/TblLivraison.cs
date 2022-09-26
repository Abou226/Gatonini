﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_livraison")]
    public partial class TblLivraison
    {
        public int Id { get; set; }
        public int? Reference { get; set; }
        public string Gateau { get; set; }
        public string Contact_Client { get; set; }
        public string Nom_Client { get; set; }
        public string Adresse_Livraison { get; set; }
        public string Livreur { get; set; }
        public DateTime? Date_Livraison { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
        public int? AuteurId { get; set; }

        public virtual TblUser AuteurNavigation { get; set; }
    }
}