using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgzaminasSVS.Models
{
    public class StorageItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public double ItemWeight { get; set; }
        [Range(1, 40, ErrorMessage ="Sandėlio sektoriai nuo 1 iki 40")]
        public int StorageSector { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime PlacementDate { get; set; }  
    }
}
