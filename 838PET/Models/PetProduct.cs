using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _838PET.Models
{
    public class PetProduct
    {

        #region Prop

        [Key]
        public int ProductID { get; set; }

        public double Valor { get; set; }

        #endregion
    }
}
