using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public abstract class ComponenteEntity
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

        public abstract IList<ComponenteEntity> Hijos { get; }
        public abstract void AgregarHijo(ComponenteEntity c);
        public abstract void VaciarHijos();
        public abstract void QuitarHijo(ComponenteEntity c);
        public TipoPermiso? Permiso { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
