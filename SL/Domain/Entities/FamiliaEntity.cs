using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public class FamiliaEntity : ComponenteEntity
    {
        private IList<ComponenteEntity> _hijos;
        public FamiliaEntity()
        {
            _hijos = new List<ComponenteEntity>();
        }

        public override IList<ComponenteEntity> Hijos
        {
            get
            {
                return _hijos.ToArray();
            }

        }

        public override void VaciarHijos()
        {
            _hijos = new List<ComponenteEntity>();
        }
        public override void AgregarHijo(ComponenteEntity c)
        {
            _hijos.Add(c);
        }
    }
}
