using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgzaminasSVS.Models
{
    public enum ClientType
    {
        Paprastas,
        VIP 
    }
    public class StorageClient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public int Phone { get; set; }
        public ClientType ClientType { get; set; }
        public int? TotalItems { get; set; }
    }
}
