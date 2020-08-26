using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZagrosRealState.Entities.Entities
{
    public class Province
    {
        [Key]
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public virtual List<Cities> Cities { get; set; }
    }
}
