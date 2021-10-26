using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("BlocoTarefas")]
        public int BlocoId{get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFinal { get; set; }
        public string Descricao { get; set; }
        public virtual BlocoTarefas BlocoTarefas { get; set; }
    }
}
