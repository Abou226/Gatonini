﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_num_cmd_partenaire")]
    public partial class TblNum_CmdPartenaire
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string Order { get; set; }
        public DateTime? Date { get; set; }
    }
}