﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaMiaPizzeriaEFPost.Models
{
    public class Pizza
    {

        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [StringLength(100, ErrorMessage = "Il nome non può essere più di 100 caratteri")]
        [Required(ErrorMessage = "Il campo del nome è obbligatorio")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(1000)")]
        [StringLength(1000, ErrorMessage = "La descrizione non può essere più di 1000 caratteri")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(500)")]
        [StringLength(500, ErrorMessage = "Il percorso dell'immagine non può essere più di 500 caratteri")]
        public string Image { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        [Required(ErrorMessage = "Il campo del prezzo è obbligatorio")]
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
