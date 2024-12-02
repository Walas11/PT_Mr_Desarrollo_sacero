using PT_Mr_Desarrollo.Infraestructura.DataBase.Entities.UsuarioEntity;

namespace PT_Mr_Desarrollo.Infraestructura.Repositorio.Usuario
{
    public interface IUsuarioRepositorio
    {
        UsuarioEntity Actualizar(UsuarioEntity clienteEntity);
        UsuarioEntity Crear(UsuarioEntity clienteEntity);
        void Eliminar(UsuarioEntity clienteEntity);
        List<UsuarioEntity> ObtenerUsuarios();
        UsuarioEntity ObtenerUsuario(int id);
    }
}
