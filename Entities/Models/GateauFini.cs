﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("GateauFini")]
    public class GateauFini
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Stock))]
        public Guid? StockId { get; set; }
        public Stock_Produit Stock { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantité { get; set; }
        public DateTime Date { get; set; }
        public Guid? UserId { get; set; }
    }
}
