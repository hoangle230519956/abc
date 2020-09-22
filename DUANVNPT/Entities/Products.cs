using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DUANVNPT.Entities
{
    [Table("Products")]
    public class Products
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int  Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DataCreated { set; get; }
        public int SeoAlias { set; get; }
    } 
}
