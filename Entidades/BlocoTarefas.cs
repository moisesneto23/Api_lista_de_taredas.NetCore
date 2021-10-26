using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BlocoTarefas
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public virtual List<Tarefa> Tarefas { get; set; } 
        public virtual Usuario? Usuario { get; set; }
    }
}
