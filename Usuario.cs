using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using videoFormulario.Modelo;

namespace videoFormulario.Dato
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();
        /// <summary>
        /// guarda los usuarios
        /// </summary>
        /// <param name="modelo">datos del usuario</param>
        public void Guardar(UsuarioModel modelo)
        {
            lista.Add(modelo);
        }
        /// <summary>
        /// Consulta todos los Usuarios
        /// </summary>
        /// <returns>datos de usuarios</returns>
        public List<UsuarioModel> Consultar()
        {
            return lista;
        }
    }
}
