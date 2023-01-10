using System.ComponentModel.DataAnnotations.Schema;

namespace LaMiaPizzeriaEFPost.Models
{
    public class Pizza
    {

        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Image { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public double Price { get; set; }


        public Pizza()
        {

        }

        public Pizza(string name, string description, string image, double price)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }

    }
}
