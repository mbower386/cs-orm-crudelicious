using System;
using System.ComponentModel.DataAnnotations;

namespace Crudelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        public string Name { get; set; }
        public string Chef { get; set; }
        public int Tastiness { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}