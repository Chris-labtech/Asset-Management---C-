using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement_CommonLibrary.Models
{
    public class Asset
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string Category { get; set; }
        public float Value { get; set; }
        public required string Currency { get; set; }
        public DateTime DateCreatedInDb { get; set; }
        public required string Location { get; set; }
    }
}
