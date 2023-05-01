using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.Entity
{
    public class FoodItem : DescriptiveEntityBase
    {
        [Required]
        public UnitOfMeasure UnitOfMeasure { get; set; } = UnitOfMeasure.Cups;
        [Required]
        public double ProteinGrams { get; set; } = 0;
        [Required]
        public double CarbohydrateGrams { get; set; } = 0;
        [Required]
        public double FatGrams { get; set; } = 0;
        [Required]
        public double SodiumGrams { get; set; } = 0;
        [Required]
        public double CholesterolGrams { get; set; } = 0;
    }

    public enum UnitOfMeasure : int
    {
        Cups,
        Ounces
    }
}
