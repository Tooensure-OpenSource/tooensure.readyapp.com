using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain.inheritances
{
    public class Person
    {
        [Required] public string? FirstName { get; set; }
        [Required] public string? LastName { get; set; }
    }
}
