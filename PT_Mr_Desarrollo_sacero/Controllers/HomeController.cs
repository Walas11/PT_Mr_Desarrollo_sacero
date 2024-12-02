using Microsoft.AspNetCore.Mvc;
using PT_Mr_Desarrollo.Infraestructura.DataBase.Entities.UsuarioEntity;
using PT_Mr_Desarrollo.Infraestructura.Repositorio.Usuario;
using PT_Mr_Desarrollo_sacero.Models;
using System.Diagnostics;

namespace PT_Mr_Desarrollo_sacero.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public HomeController(ILogger<HomeController> logger, IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        /// <summary>
        /// Vista principal
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var users = GetUser();

            if (users == null)
            {
                // Maneja el caso en que no se encuentren usuarios
                return View("Error");
            }

            return View(users);
        }

        /// <summary>
        /// Crear Usuario
        /// </summary>
        /// <returns></returns>
        public IActionResult CreateUser() 
        {
            return View();
        }

        // Guardar el nuevo usuario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UsuarioEntity usuarioNuevo)
        {
            if (ModelState.IsValid)
            {
                // Lógica para agregar el usuario
                _usuarioRepositorio.Crear(usuarioNuevo);

                return RedirectToAction("Index"); // Redirige a la lista de usuarios
            }

            return View(usuarioNuevo);
        }

        /// <summary>
        /// Obtener usuarios a mostrar
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<UsuarioEntity> GetUser()
        {
            return _usuarioRepositorio.ObtenerUsuarios();
        }

        /// <summary>
        /// Editar usuario por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var usuario = _usuarioRepositorio.ObtenerUsuario(id); // Llama al repositorio para obtener el usuario por ID
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario); // Devuelve el modelo con los datos del usuario
        }

        // PUT: Actualizar el usuario
        [HttpPost]
        public IActionResult UpdateUser(int id, UsuarioEntity usuarioActualizado)
        {
            if (id != usuarioActualizado.ID)
            {
                return BadRequest();
            }

            // Llama al servicio o repositorio para actualizar el usuario
            var usuario = _usuarioRepositorio.ObtenerUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }

            // Actualiza la información del usuario
            _usuarioRepositorio.Actualizar(usuarioActualizado);

            return RedirectToAction("Index"); // Redirige a la vista principal después de la actualización
        }

        // GET: Mostrar la confirmación de eliminación
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var usuario = _usuarioRepositorio.ObtenerUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _usuarioRepositorio.Eliminar(usuario);
            return RedirectToAction("Index"); // Muestra una vista de confirmación
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
