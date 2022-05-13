using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Models
{
    public class FamiliaModel : ComponenteModel
    {
        private IList<ComponenteModel> _hijos;
        public FamiliaModel()
        {
            _hijos = new List<ComponenteModel>();
        }
        public override IList<ComponenteModel> Hijos
        {
            get
            {
                return _hijos.ToArray();
            }

        }

        public override void AgregarHijo(ComponenteModel c)
        {
            _hijos.Add(c);
        }

        public override void VaciarHijos()
        {
            _hijos = new List<ComponenteModel>();
        }
    }
}
