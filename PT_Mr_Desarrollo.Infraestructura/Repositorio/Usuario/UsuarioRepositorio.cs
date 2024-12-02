using PT_Mr_Desarrollo.Infraestructura.DataBase.Context;
using PT_Mr_Desarrollo.Infraestructura.DataBase.Entities.UsuarioEntity;

namespace PT_Mr_Desarrollo.Infraestructura.Repositorio.Usuario
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly DB_PT_Mr_Desarrollo_Context _context;

        public UsuarioRepositorio(DB_PT_Mr_Desarrollo_Context context)
        {
            _context = context;
        }

        public UsuarioEntity Actualizar(UsuarioEntity clienteEntity)
        {
            _context.Usuario.Update(clienteEntity);
            _context.SaveChanges();
            return clienteEntity;
        }

        public UsuarioEntity Crear(UsuarioEntity clienteEntity)
        {
            _context.Usuario.Add(clienteEntity);
            _context.SaveChanges();
            return clienteEntity;
        }

        public void Eliminar(UsuarioEntity clienteEntity)
        {
            _context.Usuario.Remove(clienteEntity);
            _context.SaveChanges();
        }

        public List<UsuarioEntity> ObtenerUsuarios()
        {
            return _context.Usuario.ToList();
        }

        public UsuarioEntity ObtenerUsuario(int id)
        {
            return _context.Usuario.Find(id);
        }
    }
}
