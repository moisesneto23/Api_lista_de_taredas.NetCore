using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
