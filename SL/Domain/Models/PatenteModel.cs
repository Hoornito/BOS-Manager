using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Models
{
    public class PatenteModel : ComponenteModel
    {
        public override IList<ComponenteModel> Hijos
        {
            get
            {
                return new List<ComponenteModel>();
            }

        }

        public override void AgregarHijo(ComponenteModel c)
        {
            throw new NotImplementedException();
        }

        public override void VaciarHijos()
        {
            throw new NotImplementedException();
        }
    }
}
