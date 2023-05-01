using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.Entity
{
    public class MealComponent : EntityBase
    {
        [Required]
        public long MealId { get; set; }
        [ForeignKey(nameof(MealId))]
        public virtual Meal Meal { get; set; } = default!;

        [Required]
        public long FoodItemId { get; set; }
        [ForeignKey(nameof(FoodItemId))]
        public virtual FoodItem FoodItem { get; set; } = default!;
    }
}
