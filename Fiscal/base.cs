using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirebirdSql.Data.FirebirdClient;
using Fiscal.Properties;

namespace Fiscal {
    public class DataContext {
        public class ConnectionParams {
            public string ConnectionString() {
                return $"DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTER.FDB;Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";

            }
        }
        public class ConnectBd : DbContext {
            public DbSet<ClassContabilista> Contabilista { get; set; }
            public DbSet<ClassEmitente> Emitente { get; set; }
            public DbSet<ClassFornecedor> Fornecedor { get; set; }
            public DbSet<ClassVendaNFCe> VendaNFCe { get; set; }
            public DbSet<ClassClientes> Cliente { get; set; }
            public DbSet<ClassVendaNFe> VendaNFe { get; set; }
            public DbSet<ClassEstoque> Estoque { get; set; }
            public DbSet<ClassCompra> Compra { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder) {

                base.OnModelCreating(modelBuilder);
                new ClassContabilistaEntityTypeConfiguration().Configure(modelBuilder.Entity<ClassContabilista>());
                new ClassEmitenteEntityTypeConfiguration().Configure(modelBuilder.Entity<ClassEmitente>());
                new ClassFornecedorEntityTypeConfiguration().Configure(modelBuilder.Entity<ClassFornecedor>());
                new ClassVendaNFCeEntityTypeConfiguration().Configure(modelBuilder.Entity<ClassVendaNFCe>());
                new ClassClienteEntityTypeConfiguration().Configure(modelBuilder.Entity<ClassClientes>());
                new ClassVendaNFeEntityTypeConfiguration().Configure(modelBuilder.Entity<ClassVendaNFe>());
                new ClassCompraEntityTypeConfiguration().Configure(modelBuilder.Entity<ClassCompra>());
                new ClassEstoqueEntityTypeConfiguration().Configure(modelBuilder.Entity<ClassEstoque>());
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
                optionsBuilder.UseFirebird(new ConnectionParams().ConnectionString());
            }
        }
    }
}
