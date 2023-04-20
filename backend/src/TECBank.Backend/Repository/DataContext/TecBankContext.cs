using Microsoft.EntityFrameworkCore;
using TECBank.Backend.Domains.Models;

namespace TECBank.Backend.Repository.DataContext;

public class TecBankContext : DbContext
{
    public TecBankContext(DbContextOptions<TecBankContext> options) : base(options) { }

    public DbSet<Transacao> Transacoes { get; set; } = null!;
    public DbSet<ContaCorrente> ContasCorrentes { get; set; } = null!;

    public override int SaveChanges(
        bool acceptAllChangesOnSuccess)
    {
        var entradas = ChangeTracker
            .Entries()
            .Where(e => e.Entity is EntidadeBase &&
                (e.State == EntityState.Added || 
                 e.State == EntityState.Modified));

        foreach (var entrada in entradas)
        {
            DateTimeOffset dataHora = DateTimeOffset.Now;

            if (entrada.State == EntityState.Added)
                ((EntidadeBase)entrada.Entity).CriadoEm = dataHora;

            if (entrada.State == EntityState.Modified)
                ((EntidadeBase)entrada.Entity).AtualizadoEm = dataHora;
        }

        return base.SaveChanges(acceptAllChangesOnSuccess);
    }
}
