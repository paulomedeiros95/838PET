using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _838PET.Models
{
    public class PetServicos
    {
        #region Prop
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Category { get; set; }
        public string TechnicalDescription { get; set; }
        public string ComercialDescription { get; set; }
        public double ServiceSubscribe { get; set; }
        public double PriceMinimum { get; set; }
        public double MaxValue { get; set; }

        #endregion

    }
}
