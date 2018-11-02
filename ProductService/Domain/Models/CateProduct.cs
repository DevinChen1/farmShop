using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductService.Domain.Models
{
   public class CateProduct
    {
        public CateProduct() { Id = Guid.NewGuid().ToString("N"); }
        [Key]
        public string Id { get; set; }
        public string CateId { set; get; }//分类id
        public string Pid { get; set; }//商品id
    }
}
