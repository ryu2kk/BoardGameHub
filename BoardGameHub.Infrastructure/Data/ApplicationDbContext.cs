using BoardGameHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHub.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Jogos> db_Jogos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Jogos>().HasData(
                new Jogos
                {
                    Id = 1,
                    Name = "Catan",
                    Category = "Estratégia",
                    Description = "Catan é um jogo de estratégia no qual os jogadores competem para construir colônias e expandir seu território em uma ilha fictícia.",
                    PlayerNumber = 3,
                    ImageUrl = "https://example.com/catan-image",
                    Additional = "Variações de tabuleiro, cartas de desenvolvimento, recursos (madeira, trigo, lã, etc.)"
                },

                new Jogos
                {
                    Id = 2,
                    Name = "Monopólio",
                    Category = "Clássico/Negócio",
                    Description = "Monopólio é um jogo clássico de negociação imobiliária no qual os jogadores compram, vendem e trocam propriedades para acumular riqueza e falir os seus adversários.",
                    PlayerNumber = 2,
                    ImageUrl = "https://example.com/monopoly-image",
                    Additional = "Varios modos, diferentes edições temáticas, cartas de sorte/azar."
                },

                new Jogos
                {
                    Id = 3,
                    Name = "Scythe",
                    Category = "Estratégia",
                    Description = "Scythe é um jogo de estratégia ambientado em uma realidade alternativa dos anos 1920, onde os jogadores controlam facções e competem pela supremacia em uma terra devastada pela guerra.",
                    PlayerNumber = 1,
                    ImageUrl = "https://example.com/scythe-image",
                    Additional = "Tabuleiros assimétricos, cartas de objetivos, miniaturas de unidades."
                }
            );
        }
    }
}
