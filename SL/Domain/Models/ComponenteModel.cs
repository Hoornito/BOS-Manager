using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Models
{
    public abstract class ComponenteModel
    {

        public string Nombre { get; set; }
        public int Id { get; set; }

        public abstract IList<ComponenteModel> Hijos { get; }
        public abstract void AgregarHijo(ComponenteModel c);
        public abstract void VaciarHijos();
        public TipoPermiso Permiso { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
