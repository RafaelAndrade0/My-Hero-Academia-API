using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Newtonsoft.Json;

namespace MyHeroAcademiaAPI.Dto
{
    public class HeroDto
    {
        //[JsonIgnore]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Quirk { get; set; }

        public string ImageURI { get; set; }
    }
}