﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Gamme
    {
        public Gamme()
        {
            TblPlaningGateaus = new HashSet<TblPlaningGateau>();
        }

        public Guid GammeId { get; set; }
        public Guid? CategorieId { get; set; }
        public Guid? MarqueId { get; set; }
        public Guid? StyleId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime ServerTime { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public decimal PrixUnité { get; set; }
        public int? UserId { get; set; }

        public virtual Categorie Categorie { get; set; }
        public virtual Marque Marque { get; set; }
        public virtual Style Style { get; set; }
        public virtual ICollection<TblPlaningGateau> TblPlaningGateaus { get; set; }
    }
}