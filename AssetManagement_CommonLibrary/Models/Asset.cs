using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement_CommonLibrary.Models
{
    public class Asset
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Value { get; set; }
        public string Currency { get; set; }
        public DateTime DateCreatedInDb { get; set; }
        public string Location { get; set; }


    }
}
