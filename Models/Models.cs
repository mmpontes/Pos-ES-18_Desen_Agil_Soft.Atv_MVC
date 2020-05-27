using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_MVC.Models.Domain
{
    public class Pessoa
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(15, 35)]
        public int Age { get; set; }

        [Required]
        //[RegularExpression(@"b[A-Z0-9._%-]+@[A-Z0-9.-]+.[A-Z]{2,4}b")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public string Opniao { get; set; }        
    }
}
