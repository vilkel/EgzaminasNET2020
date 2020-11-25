using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgzaminasSVS.Models
{
    public class ClientItem
    {
        [Key]
        public int ClientId { get; set; }
        public int ItemId { get; set; }
    }
}
