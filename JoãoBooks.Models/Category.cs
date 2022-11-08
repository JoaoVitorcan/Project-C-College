using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace JoãoBooks.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Categroy Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }


    }
}
