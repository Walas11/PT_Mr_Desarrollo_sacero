using Microsoft.EntityFrameworkCore;
using PT_Mr_Desarrollo.Infraestructura.DataBase.Entities.UsuarioEntity;

namespace PT_Mr_Desarrollo.Infraestructura.DataBase.Context
{
    public class DB_PT_Mr_Desarrollo_Context : DbContext
    {
        public DB_PT_Mr_Desarrollo_Context(DbContextOptions<DB_PT_Mr_Desarrollo_Context> options) : base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        #region DBSets
        public virtual DbSet<UsuarioEntity> Usuario { get; set; }

        #endregion
    }
}
