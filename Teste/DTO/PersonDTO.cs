using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Teste.DTO
{
    public class PersonDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName is required.")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required.")]
        public String LastName { get; set; }
    }
}
