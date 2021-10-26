using Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace BancoDados
{
    public class ConectaContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<BlocoTarefas> Blocos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=UpdateGamaAcademy;Trusted_Connection=True;");
        }
    }
}
