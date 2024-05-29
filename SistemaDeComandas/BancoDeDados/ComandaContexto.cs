using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.Modelos;

namespace SistemaDeComandas.BancoDeDados
{
    public class ComandaContexto : DbContext
    {
        // criar as variaveis que representam tables
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<CardapioItem> CardapioItems { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaItem> ComandaItems { get; set; }
        public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
        public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }
    }
}
