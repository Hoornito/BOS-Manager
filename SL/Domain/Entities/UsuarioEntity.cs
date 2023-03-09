using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public class UsuarioEntity
    {
        public UsuarioEntity()
        {
            _permisos = new List<ComponenteEntity>();
        }

        List<ComponenteEntity> _permisos;
        public int Id { get; set; }
        public string nombre { get; set; }
        public bool exists { get; set; }
        public string pw { get; set; }
        public string usuario { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }
        public string idioma { get; set; }
        
        public bool Access { get; set; }
        public List<ComponenteEntity> Permisos
        {
            get
            {
                return _permisos;
            }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
