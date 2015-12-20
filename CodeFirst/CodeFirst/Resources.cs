using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{ 
    public class Resource
    {
        public Resource()
        {
           
        }
        [Key]
        [Column(Order = 0)]
        public string Culture { get; set; }
        [Key]
        [Column(Order = 1)]
        public string Name { get; set; }
        
        public string Value { get; set; }
    }
}
