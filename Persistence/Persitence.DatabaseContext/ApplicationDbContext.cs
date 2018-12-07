using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Auth;
using Model.DB_Model;

namespace Persistence.DatabaseContext
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRole { get; set; }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Componentes> Componentes { get; set; }
        public virtual DbSet<EMailError> EMailError { get; set; }
        public virtual DbSet<EquipoPrincipal> EquipoPrincipal { get; set; }
        public virtual DbSet<EquipoSecundario> EquipoSecundario { get; set; }
        public virtual DbSet<EstadoServicio> EstadoServicio { get; set; }
        public virtual DbSet<HistorialPassword> HistorialPassword { get; set; }
        public virtual DbSet<Operador> Operador { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<Planta> Planta { get; set; }
        public virtual DbSet<Prioridad> Prioridad { get; set; }
        public virtual DbSet<Procesos> Procesos { get; set; }
        public virtual DbSet<RegistroEquipo> RegistroEquipo { get; set; }
        public virtual DbSet<SigoTicket> SigoTicket { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TipoTrabajo> TipoTrabajo { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<CalificacionServicio> CalificacionServicio { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("DefaultConnection");
            }
        }
    }
}
