using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GMarket.Data.Entities
{
    public class Country
    {
        public  int ID { get; set; }

        [Display(Name = "País")]
        [StringLength(30, ErrorMessage =
            "El Campo {0} puede contener {1} y minimo {2} caracteres",
            MinimumLength = 3)]       
        public string Name { get; set; }

    }
}
