using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZagrosRealState.Entities.Entities
{
    public class Cities
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        public virtual Province Province { get; set; }
        public virtual List<Customers> Customers { get; set; }
    }
}
