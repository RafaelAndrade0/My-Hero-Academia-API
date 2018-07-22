using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MyHeroAcademiaAPI.Models
{
    public class Hero
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public string Quirk { get; set; }

        [Required]
        [StringLength(200)]
        public string ImageURI { get; set; }
    }
}