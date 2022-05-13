using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public class PatenteEntity : ComponenteEntity
    {


        public override IList<ComponenteEntity> Hijos
        {
            get
            {
                return new List<ComponenteEntity>();
            }

        }

        public override void AgregarHijo(ComponenteEntity c)
        {
            throw new NotImplementedException();
        }

        public override void VaciarHijos()
        {
            throw new NotImplementedException();
        }
    }
}
